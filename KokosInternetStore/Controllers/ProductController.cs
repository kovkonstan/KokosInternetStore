using Kokos_Utility;
using Kokos_Models;
using Kokos_Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kokos_DataAccess.Data;
using Kokos_DataAccess.Repository.IRepository;

namespace KokosInternetStore.Controllers
{
    [Authorize(Roles = WebConstants.AdminRole)]
    public class ProductController : Controller
    {
        private readonly IProductRepository _prodRepo;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductRepository prodRepo, IWebHostEnvironment webHostEnvironment)
        {
            _prodRepo = prodRepo;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> objList = _prodRepo.GetAll(includeProperties: String.Format("{0},{1}", nameof(Category), nameof(ApplicationType)));

            return View(objList);
        }

        //GET - UPSERT
        public IActionResult Upsert(int? id)
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategorySelectList = _prodRepo.GetAllDropdownList(WebConstants.CategoryName),
                ApplicationTypeSelectList = _prodRepo.GetAllDropdownList(WebConstants.ApplicationTypeName)
            };

            if (id == null)
            {
                // создание новой сущности
                return View(productVM);
            }
            else
            {
                productVM.Product = _prodRepo.Find(id.GetValueOrDefault());
                if (productVM.Product == null)
                {
                    return NotFound();
                }
                return View(productVM);
            }
        }

        //POST - UPSERT
        [HttpPost]
        [ValidateAntiForgeryToken] // Защита от взлома
        public IActionResult Upsert(ProductVM productVM)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                string webRootPath = _webHostEnvironment.WebRootPath;

                if (productVM.Product.Id == 0)
                {
                    // Создание сущности
                    string upload = webRootPath + WebConstants.ImagePath;
                    string fileName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(files[0].FileName);

                    using (var fileStream = new FileStream(Path.Combine(upload, fileName+extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    productVM.Product.Image = fileName + extension;

                    _prodRepo.Add(productVM.Product);                    
                }
                else
                {
                    // Обновление сущности
                    var objFromDb = _prodRepo.FirstOrDefault(u => u.Id == productVM.Product.Id, isTracking:false);

                    if (files.Count > 0)
                    {
                        string upload = webRootPath + WebConstants.ImagePath;
                        string fileName = Guid.NewGuid().ToString();
                        string extension = Path.GetExtension(files[0].FileName);

                        var oldFile = Path.Combine(upload, objFromDb.Image);
                        if (System.IO.File.Exists(oldFile))
                        {
                            System.IO.File.Delete(oldFile);
                        }

                        using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                        {
                            files[0].CopyTo(fileStream);
                        }

                        productVM.Product.Image = fileName + extension;
                    }
                    else
                    {
                        productVM.Product.Image = objFromDb.Image;
                    }
                    _prodRepo.Update(productVM.Product);
                }

                _prodRepo.Save();
                TempData[WebConstants.Success] = "Товар изменен успешно";
                return RedirectToAction("Index");
            }

            productVM.CategorySelectList = _prodRepo.GetAllDropdownList(WebConstants.CategoryName);
            productVM.CategorySelectList = _prodRepo.GetAllDropdownList(WebConstants.ApplicationTypeName);
            TempData[WebConstants.Error] = "Ошибка при изменении товара";
            return View(productVM);
        }
        
        //GET - DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // Eager loading - жадная загрузка
            Product product = _prodRepo.FirstOrDefault(u => u.Id == id, 
                includeProperties: String.Format("{0},{1}", WebConstants.CategoryName, WebConstants.ApplicationTypeName));

            if (product == null)
            {
                return NotFound();
            }
            
            return View(product);
        }

        //POST - DELETE
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken] // Защита от взлома
        public IActionResult DeletePost(int? id)
        {
            var obj = _prodRepo.Find(id.GetValueOrDefault());
            if (obj == null)
            {
                return NotFound();
            }

            string upload = _webHostEnvironment.WebRootPath + WebConstants.ImagePath;            
            var oldFile = Path.Combine(upload, obj.Image);

            if (System.IO.File.Exists(oldFile))
            {
                System.IO.File.Delete(oldFile);
            }

            _prodRepo.Remove(obj);
            _prodRepo.Save();
            TempData[WebConstants.Success] = "Товар успешно удален";

            return RedirectToAction("Index");
        }
    }
}
