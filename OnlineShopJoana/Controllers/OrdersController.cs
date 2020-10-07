using Microsoft.AspNetCore.Mvc;
using OnlineShopJoana.Helpers;
using OnlineShopJoana.WEB.Data.Repositories;
using OnlineShopJoana.WEB.Helpers;
using OnlineShopJoana.WEB.Models;

using System;
using System.Threading.Tasks;

namespace OnlineShopJoana.WEB.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IUserHelper _userHelper;
        private readonly IMailHelper _mailHelper;

        public OrdersController(IOrderRepository orderRepository,
            IProductRepository productRepository,
            IUserHelper userHelper,
            IMailHelper mailHelper)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _userHelper = userHelper;
            _mailHelper = mailHelper;
        }

        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            var model = await _orderRepository.GetOrdersAsync(User.Identity.Name);
            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            var model = await _orderRepository.GetDetailTempsAsync(User.Identity.Name);
            return View(model);
        }

        public IActionResult AddProduct()
        {
            var model = new AddItemViewModel
            {
                Quantity = 1,
                Products = _productRepository.GetComboProducts()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _orderRepository.AddItemToOrderAsync(model, User.Identity.Name);
                return RedirectToAction("Create");
            }
            return View(model);
        }

        public async Task<IActionResult> DeleteItem(int? id)
        {

            if (id == null)
            {
                return NotFound();

            }

            await _orderRepository.DeleteDetailTempAsync(id.Value);

            return RedirectToAction("Create");
        }

        public async Task<IActionResult> Increase(int? id)
        {

            if (id == null)
            {
                return NotFound();

            }

            await _orderRepository.ModifyOrderDetailTempQuantityAsync(id.Value, 1);

            return RedirectToAction("Create");
        }

        public async Task<IActionResult> Decrease(int? id)
        {

            if (id == null)
            {
                return NotFound();

            }

            await _orderRepository.ModifyOrderDetailTempQuantityAsync(id.Value, -1);

            return RedirectToAction("Create");
        }

        public async Task<IActionResult> ConfirmOrder()
        {
            var createdOrder = await _orderRepository.ConfirmOrderAsync(User.Identity.Name);

            if (createdOrder != null)
            {
                try
                {
                    EmailWithPdf generator = new EmailWithPdf();

                    var pdfByteArray = generator.CreatePdf(createdOrder, User.Identity.Name);

                    _mailHelper.SendMailWithAttachment(User.Identity.Name, "Order - Plants Store",
                        "Thank you very much for choosing us!\n The invoice is attached", pdfByteArray);


                    ModelState.Clear();
                    ViewBag.Message = "Thank you very much for choosing us!\n\n\nSee your email box.";

                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception.Message);
                }
            }

            return View();
        }

        public async Task<IActionResult> Deliver(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _orderRepository.GetOrderAsync(id.Value);

            if (order == null)
            {
                return NotFound();

            }

            var model = new DeliverViewModel
            {
                Id = order.Id,
                DeliveryDate = DateTime.Today
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Deliver(DeliverViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _orderRepository.DeliverOrderAsync(model);
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
