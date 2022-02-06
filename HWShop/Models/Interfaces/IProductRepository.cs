using System.Linq;


namespace HWShop.Models.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get;}
        void SaveProduct(Product product);
        Product DeleteProduct(int productID);
    }
}
