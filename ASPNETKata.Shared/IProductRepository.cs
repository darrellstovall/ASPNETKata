using System.Collections.Generic;

namespace InversionOfControl.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void DeleteProduct(int productId);
        void UpdateProduct(Product prod);
        void InsertProduct(Product prod);
        Product GetDetails(int productId);
    }
}