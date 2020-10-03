﻿using Microsoft.AspNetCore.Mvc;
using OnlineShopJoana.WEB.Data.Repositories;
using OnlineShopJoana.WEB.Models;
using System;
using System.Threading.Tasks;

namespace OnlineShopJoana.WEB.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrdersController(IOrderRepository orderRepository,
            IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _orderRepository.GetOrdersAsync(User.Identity.Name);
            return View(model);
        }

        public async Task<IActionResult> Create()
        {
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
            var response = await _orderRepository.ConfirmOrderAsync(User.Identity.Name);

            if (response)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Create");
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
