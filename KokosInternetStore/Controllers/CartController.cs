using Kokos_DataAccess.Data;
using Kokos_DataAccess.Repository.IRepository;
using Kokos_Models;
using Kokos_Models.ViewModels;
using Kokos_Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace KokosInternetStore.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly IProductRepository _prodRepo;
        private readonly IApplicationUserRepository _userRepo;
        private readonly IInquiryHeaderRepository _inqHRepo;
        private readonly IInquiryDetailRepository _inqDRepo;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IEmailSender _emailSender;

        [BindProperty]
        public ProductUserVM ProductUserVM { get; set; }

        public CartController(IProductRepository prodRepo,
            IApplicationUserRepository userRepo,
            IInquiryHeaderRepository inqHRepo,
            IInquiryDetailRepository inqDRepo,
            IWebHostEnvironment webHostEnvironment,
            IEmailSender emailSender)
        {
            _emailSender = emailSender;
            _webHostEnvironment = webHostEnvironment;
            _prodRepo = prodRepo;
            _userRepo = userRepo;
            _inqHRepo = inqHRepo;
            _inqDRepo = inqDRepo;
        }

        public IActionResult Index()
        {
            List<ShoppingCart> ShoppingCartList = new List<ShoppingCart>();

            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WebConstants.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WebConstants.SessionCart).Count() > 0)
            {
                ShoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WebConstants.SessionCart);
            }

            List<int> prodInCart = ShoppingCartList.Select(i => i.ProductId).ToList();
            IEnumerable<Product> prodListTemp = _prodRepo.GetAll(u => prodInCart.Contains(u.Id));
            IList<Product> prodList = new List<Product>();

            foreach (var cartObj in ShoppingCartList)
            {
                Product prodTemp = prodListTemp.FirstOrDefault(u => u.Id == cartObj.ProductId);
                prodTemp.TempQuantity = cartObj.Quantity;
                prodList.Add(prodTemp);
            }

            return View(prodList);
        }

        // Вызывается при нажатии на кнопку Продолжить в Корзине
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public IActionResult IndexPost(IEnumerable<Product> prodList)
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            foreach (Product prod in prodList)
            {
                shoppingCartList.Add(new ShoppingCart { ProductId = prod.Id, Quantity = prod.TempQuantity });
            }

            HttpContext.Session.Set(WebConstants.SessionCart, shoppingCartList);
            
            return RedirectToAction(nameof(Summary));
        }

        public IActionResult Summary()
        {
            ApplicationUser applicationUser;

            if (User.IsInRole(WebConstants.AdminRole))
            {
                if (HttpContext.Session.Get<int>(WebConstants.SessionInquiryId) != 0)
                {
                    // корзина была загружена на основании запроса
                    InquiryHeader inquiryHeader = _inqHRepo.FirstOrDefault(u => u.Id ==
                        HttpContext.Session.Get<int>(WebConstants.SessionInquiryId));
                    applicationUser = new ApplicationUser()
                    {
                        Email = inquiryHeader.Email,
                        FullName = inquiryHeader.FullName,
                        PhoneNumber = inquiryHeader.PhoneNumber
                    };
                }
                else
                {
                    applicationUser = new ApplicationUser();
                }
            }
            else
            {
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                // Первый способ получения идентификатора пользователя
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                // var userId = User.FindFirstValue(ClaimTypes.Name); // Второй способ

                applicationUser = _userRepo.FirstOrDefault(u => u.Id == claim.Value);
            }

            List<ShoppingCart> ShoppingCartList = new();

            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WebConstants.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WebConstants.SessionCart).Count() > 0)
            {
                // сессия существует
                ShoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WebConstants.SessionCart);
            }

            List<int> prodInCart = ShoppingCartList.Select(i => i.ProductId).ToList();
            IEnumerable<Product> prodList = _prodRepo.GetAll(u => prodInCart.Contains(u.Id));

            ProductUserVM = new ProductUserVM()
            {
                ApplicationUser = applicationUser                
            };

            foreach (var cartObj in ShoppingCartList)
            {
                Product prodTemp = _prodRepo.FirstOrDefault(u => u.Id == cartObj.ProductId);
                prodTemp.TempQuantity = cartObj.Quantity;
                ProductUserVM.ProductList.Add(prodTemp);
            }

            return View(ProductUserVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Summary")]
        public async Task<IActionResult> SummaryPost(ProductUserVM ProductUserVM)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            var pathToTemplate = _webHostEnvironment.WebRootPath + Path.DirectorySeparatorChar.ToString()
                + "templates" + Path.DirectorySeparatorChar.ToString()
                + "Inquiry.html";

            var subject = "Новый заказ";
            string HtmlBody = "";
            using (StreamReader sr = System.IO.File.OpenText(pathToTemplate))
            {
                HtmlBody = sr.ReadToEnd();
            }

            StringBuilder productListSB = new StringBuilder();
            foreach (var prod in ProductUserVM.ProductList)
            {
                productListSB.Append($" - Name: { prod.Name} <span style='font-size:14px;'> (ID: {prod.Id})</span><br />");
            }

            string messageBody = string.Format(HtmlBody,
                ProductUserVM.ApplicationUser.FullName,
                ProductUserVM.ApplicationUser.Email,
                ProductUserVM.ApplicationUser.PhoneNumber,
                productListSB.ToString());

            await _emailSender.SendEmailAsync(WebConstants.EmailAdmin, subject, messageBody);

            InquiryHeader inquiryHeader = new InquiryHeader()
            {
                ApplicationUserId = claim.Value,
                FullName = ProductUserVM.ApplicationUser.FullName,
                Email = ProductUserVM.ApplicationUser.Email,
                PhoneNumber = ProductUserVM.ApplicationUser.PhoneNumber,
                InquiryDate = DateTime.Now
            };

            _inqHRepo.Add(inquiryHeader);
            _inqHRepo.Save();

            foreach (var prod in ProductUserVM.ProductList)
            {
                InquiryDetail inquiryDetail = new InquiryDetail()
                {
                    InquiryHeaderId = inquiryHeader.Id,
                    ProductId = prod.Id
                };
                _inqDRepo.Add(inquiryDetail);
            }
            _inqDRepo.Save();
            TempData[WebConstants.Success] = "Заказ успешно создан";

            return RedirectToAction(nameof(InquiryConfirmation));
        }

        public IActionResult InquiryConfirmation()
        {
            HttpContext.Session.Clear();

            return View();
        }

        public IActionResult Remove(int id)
        {
            List<ShoppingCart> ShoppingCartList = new List<ShoppingCart>();

            if (HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WebConstants.SessionCart) != null
                && HttpContext.Session.Get<IEnumerable<ShoppingCart>>(WebConstants.SessionCart).Count() > 0)
            {
                ShoppingCartList = HttpContext.Session.Get<List<ShoppingCart>>(WebConstants.SessionCart);
            }

            ShoppingCartList.Remove(ShoppingCartList.FirstOrDefault(u => u.ProductId == id));
            HttpContext.Session.Set(WebConstants.SessionCart, ShoppingCartList);
            TempData[WebConstants.Success] = "Товар удален из корзины";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCart(IEnumerable<Product> prodList)
        {
            List<ShoppingCart> shoppingCartList = new List<ShoppingCart>();
            foreach (Product prod  in prodList)
            {
                shoppingCartList.Add(new ShoppingCart { ProductId = prod.Id, Quantity = prod.TempQuantity });
            }

            HttpContext.Session.Set(WebConstants.SessionCart, shoppingCartList);
            TempData[WebConstants.Success] = "Корзина успешно обновлена";

            return RedirectToAction(nameof(Index));
        }
    }
}
