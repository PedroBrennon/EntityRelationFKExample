using EntityRelationFKExample.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityRelationFKExample.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task AddProduct(Product product);
        Task<List<ProductItem>> GetProductItems();
        Task AddProductItem(ProductItem productItem);
    }
}
