using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HWShop.Models.Interfaces;
using HWShop.Models;
using Microsoft.EntityFrameworkCore;

namespace HWShop.Controllers
{
    public class AdminController : Controller
    {

        IProductRepository repository;
        public AdminController(IProductRepository repo)
        {
            this.repository = repo;
        }
        
        public IActionResult ProductList()
        {
            return View(repository.Products);
        }
        [HttpGet]
        public IActionResult Edit(int productId)
        {
            return View(repository.Products.FirstOrDefault(p => p.ProductID == productId));
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"{product.Name} has beed saved";
                return RedirectToAction("ProductList");
            }
            else
            {
                return View(product);
            }
        }
        public IActionResult Add()
        {
            return View("Edit",new Product());
        }
        [HttpPost]
        public IActionResult Delete(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = $"{deletedProduct.Name} was deleted";
            }
            return RedirectToAction("ProductList");
        }
    }
}
