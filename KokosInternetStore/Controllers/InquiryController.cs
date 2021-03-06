using Kokos_Utility;
using Kokos_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kokos_DataAccess.Data;
using Kokos_DataAccess.Repository.IRepository;
using Kokos_Models.ViewModels;

namespace KokosInternetStore.Controllers
{
    [Authorize(Roles = WebConstants.AdminRole)]
    public class InquiryController : Controller
    {
        private IInquiryHeaderRepository _inqHRepo;
        private IInquiryDetailRepository _inqDRepo;
        
        [BindProperty] // При создании запроса типа post все данные будут по умолчанию доступны (модель заполнится автоматически)
        public InquiryVM InquiryVM { get; set; }

        public InquiryController(IInquiryHeaderRepository inqHRepo, IInquiryDetailRepository inqDRepo)
        {
            _inqHRepo = inqHRepo;
            _inqDRepo = inqDRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            InquiryVM = new InquiryVM
            {
                InquiryHeader = _inqHRepo.FirstOrDefault(u => u.Id == id),
                InquiryDetail = _inqDRepo.GetAll(u => u.InquiryHeaderId == id, 
                    includeProperties: nameof(Product))
            };

            return View(InquiryVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details()
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            InquiryVM.InquiryDetail = _inqDRepo.GetAll(u => u.InquiryHeaderId == InquiryVM.InquiryHeader.Id);

            foreach (var detail in InquiryVM.InquiryDetail)
            {
                ShoppingCart shoppingCart = new ShoppingCart()
                {
                    ProductId = detail.ProductId
                };
                shoppingCartList.Add(shoppingCart);
            }

            HttpContext.Session.Clear();
            HttpContext.Session.Set(WebConstants.SessionCart, shoppingCartList);
            HttpContext.Session.Set(WebConstants.SessionInquiryId, InquiryVM.InquiryHeader.Id);
            TempData[WebConstants.Success] = "Товары успешно переданы в корзину";

            return RedirectToAction("Index", "Cart");
        }

        [HttpPost]
        public IActionResult Delete() 
        {
            InquiryHeader inquiryHeader = _inqHRepo.FirstOrDefault(u => u.Id == InquiryVM.InquiryHeader.Id);
            IEnumerable<InquiryDetail> inquiryDetails = _inqDRepo
                .GetAll(u => u.InquiryHeaderId == InquiryVM.InquiryHeader.Id);

            _inqDRepo.RemoveRange(inquiryDetails);
            _inqHRepo.Remove(inquiryHeader);
            _inqHRepo.Save();

            TempData[WebConstants.Success] = "Заказ успешно удален";
            return RedirectToAction(nameof(Index));
        }

        #region API CALLS
        // Используется в работе компонентом DataTables на странице Index для отображения запросов  
        [HttpGet]
        public IActionResult GetInquiryList()
        {
            return Json(new { data=_inqHRepo.GetAll() });
        }

        #endregion
    }
}
