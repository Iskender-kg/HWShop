using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HWShop.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HWShop.Models
{
    public class EFProductRepository: IProductRepository
    {
        HardWareDBContext ctx;
        public EFProductRepository(HardWareDBContext context)
        {
            ctx = context;
        }
        public IQueryable<Product> Products => ctx.Products;
        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0)
            {
                ctx.Products.Add(product);
            }
            else
            {
                Product dbentry = ctx.Products.FirstOrDefault(p => p.ProductID == product.ProductID);
                if (dbentry != null)
                {
                    dbentry.Name = product.Name;
                    dbentry.Price = product.Price;
                    dbentry.Category = product.Category;
                    dbentry.Description = product.Description;
                    dbentry.Amount = product.Amount;
                }
            }
            ctx.SaveChanges();
        }
        public Product DeleteProduct(int productID)
        {
            Product dbentry = ctx.Products.FirstOrDefault(p => p.ProductID == productID);
            if (dbentry != null)
            {
                ctx.Products.Remove(dbentry);
                ctx.SaveChanges();
            }
            return dbentry;
        }
    }
}
