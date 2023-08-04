﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTested.AspNetCore.Mvc.Utilities.Extensions;
using SwimmingClubApp.Infrastructure;
using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Orders;
using SwimmingClubApp.Services.Orders.Models;
using SwimmingClubApp.Services.Products;
using SwimmingClubApp.Services.Products.Models;
using System.Security.Claims;
using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Controllers
{
    [Authorize(Roles = AdminRoleName)]
    public class ClubShopController : Controller
    {
        private readonly IProductService products;
        private readonly IOrderService orders;
        private readonly IMapper mapper;

        public ClubShopController(IProductService products, IMapper mapper, IOrderService orders)
        {
            this.products = products;
            this.mapper = mapper;
            this.orders = orders;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Order(ProductOrderInputModel product)
        {
            var order = this.mapper.Map<OrderServiceModel>(product);
            order.IssuerId = this.User.GetId();

            this.orders.CreateOrder(order);
            return this.Redirect("/");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Cart()
        {
            var orders = this.orders
                .All()
                .Where(o => o.Status.Name == "Active")
                .ToList();

            var cart = this.mapper.Map<OrderCartViewModel>(orders);
            cart.Sum = cart.Quantity * cart.Price;

            return View(cart);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult CompleteOrder()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View(new ProductFormModel()
            {
                AllSizes = this.products.AllSizeOptions(),
                ProductCategories = this.products.AllProductCategories()
            });
        }

        [HttpPost]
        public IActionResult AddProduct(ProductFormModel product)
        {
            if (!this.products.ProductCategoriesExist(product.ProductCategoryId))
            {
                this.ModelState.AddModelError(nameof(product.ProductCategoryId), "Category does not exist");
            }

            foreach (var size in product.AllSizes)
            {
                if (!this.products.AllSizeOptions().Any(p => p.Id == size.Id))
                {
                    this.ModelState.AddModelError(nameof(size.Id), "Size does not exist");
                }
            }

            if (!ModelState.IsValid)
            {
                product.AllSizes = this.products.AllSizeOptions();
                product.ProductCategories = this.products.AllProductCategories();
                return View(product);

            }


            this.products.CreateProduct(product.Name, product.Image, product.Price, product.ProductCategoryId, product.AllSizes);

            return RedirectToAction(nameof(AllProducts));
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            if (!this.products.ProductExists(id))
            {
                return BadRequest();
            }
            var product = this.products.ProductDetails(id);

            return View(product);
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var product = this.products.ProductDetails(id);

            this.products.AllSizeOptions();
            this.products.AllProductCategories();

            if (!this.products.ProductCategoriesExist(product.ProductCategoryId))
            {
                this.ModelState.AddModelError(nameof(product.ProductCategoryId), "Category does not exist");
            }

            //var productForm = this.mapper.Map<ProductFormModel>(product);
            //productForm.ProductCategories = products.AllProductCategories();
            //productForm.AllSizes = products.AllSizeOptions();

            return View(new ProductFormModel
            {
                Name = product.Name,
                Image = product.Image,
                Price = product.Price,
                ProductCategoryId = product.ProductCategoryId,
                ProductCategories = products.AllProductCategories(),
                AllSizes = products.AllSizeOptions()
            });
            // return View(productForm);
        }

        [HttpPost]
        public IActionResult EditProduct(int id, ProductFormModel product)
        {

            if (!this.products.ProductCategoriesExist(product.ProductCategoryId))
            {
                this.ModelState.AddModelError(nameof(product.ProductCategoryId), "Category does not exist");
            }

            //Should I check if all sizes in SizeOptions exists and how?
            //foreach (var size in product.AllSizes)
            //{
            //    if (!this.products.AllSizeOptions().Any(p => p.Id == size.Id))
            //    {
            //        this.ModelState.AddModelError(nameof(size.Id), "Size does not exist");
            //    }
            //}

            if (!ModelState.IsValid)
            {
                product.AllSizes = this.products.AllSizeOptions();
                product.ProductCategories = this.products.AllProductCategories();
                return View(product);

            }
            this.products.EditProduct(id, product.Name, product.Image, product.Price, product.ProductCategoryId, product.AllSizes);
            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public IActionResult DeleteProduct(int id)

        {
            if (!this.products.ProductExists(id))
            {
                ModelState.AddModelError("", "Product does not exist.");
                return RedirectToAction(nameof(AllProducts));
            }

            var product = this.products.ProductDetails(id);
            // var toDelete = this.mapper.Map<ProductDetailsServiceModel>(product);
            var toDelete = new ProductDetailsServiceModel
            {
                Name = product.Name,
                Image = product.Image,
                Price = product.Price,
                ProductCategoryId = product.ProductCategoryId,
                SizesList = product.SizesList
            };

            return View(toDelete);
        }

        [HttpPost]
        public IActionResult DeleteProduct(int id, ProductDetailsServiceModel product)
        {
            if (!this.products.ProductExists(id))
            {
                ModelState.AddModelError("", "Product does not exist.");
                return RedirectToAction(nameof(AllProducts));
            }

            var toDelete = this.products.ProductDetails(id);

            if (!this.products.ProductCategoriesExist(product.ProductCategoryId))
            {
                this.ModelState.AddModelError(nameof(product.ProductCategoryId), "Category does not exist");
            }
            //Should I check if all sizes in SizeOptions exists and how?

            this.products.DeleteProduct(id);

            return RedirectToAction(nameof(AllProducts));
        }

        [AllowAnonymous]
        public IActionResult AllProducts([FromQuery] AllProductsQueryModel query)
        {
            var products = this.products.AllProducts(query.Category, query.Sorting, query.CurrentPage, AllProductsQueryModel.ProductsPerPage);


            query.TotalProductsCount = products.TotalProducts;
            query.Products = products.Products;

            var categories = this.products.ProductCategoriesNames();
            query.Categories = categories;

            return View(query);
        }


    }
}
