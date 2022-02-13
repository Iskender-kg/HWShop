using HWShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using HWShop.Models.Interfaces;
using HWShop.Models.ViewModels;

namespace HWShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository repository;
        public int ProductsByPage = 4;

        public ProductsController(IProductRepository repo)
        {
            this.repository = repo;
        }
        public IActionResult ProductList(string category, int productpage = 1)
        {
            return View(new ProductListViewModel{Products = repository.Products
                .Where(p=> category==null || p.Category==category)
                .OrderBy(p => p.ProductID)
                .Skip((productpage - 1) * ProductsByPage)
                .Take(ProductsByPage),
                PagingInfo = new PagingInfo {
                    TotalItems = category==null ? repository.Products.Count(): repository.Products.Where(p=>p.Category==category).Count(),
                    ItemsPerPages = ProductsByPage,
                    CurrentPage = productpage
                }, CurrentCategory= category
            });
        }

    }
}
