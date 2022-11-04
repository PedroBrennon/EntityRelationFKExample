using EntityRelationFKExample.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityRelationFKExample.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<Product> Create(Product product);
        Task<ProductItem> CreateItem(ProductItem productItem);
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<List<ProductItem>> GetAllItems();
    }
}
