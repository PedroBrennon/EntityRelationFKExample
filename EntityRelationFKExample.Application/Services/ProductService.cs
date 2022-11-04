using EntityRelationFKExample.Domain.Entities;
using EntityRelationFKExample.Domain.Interfaces.Repositories;
using EntityRelationFKExample.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityRelationFKExample.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddProduct(Product product)
        {
            await _productRepository.Create(product);
        }

        public async Task AddProductItem(ProductItem productItem)
        {
            await _productRepository.CreateItem(productItem);
        }

        public async Task<List<ProductItem>> GetProductItems()
        {
            var productItems = await _productRepository.GetAllItems();

            foreach (var pi in productItems)
            {
                var product = await _productRepository.GetById(pi.ProductId);

                pi.Product = product;
            }

            return productItems;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _productRepository.GetAll();
        }
    }
}
