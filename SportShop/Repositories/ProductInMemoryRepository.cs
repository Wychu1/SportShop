using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class ProductInMemoryRepository : IProductRepository
    {
        public IEnumerable<ProductGridViewModel> GetProducts()
        {
            return new[]
            {
                new ProductGridViewModel
                {
                    Id = 1,
                    Name = "Produkt pierwszy",
                    Price = 10
                },

                new ProductGridViewModel
                {
                    Id = 2,
                    Name = "Produkt drugi",
                    Price = 20
                },

                new ProductGridViewModel
                {
                    Id = 3,
                    Name = "Produkt trzeci",
                    Price = 30
                }

            };
        }

        public ProductDetailsViewModel Get(long id)
        {
            return new ProductDetailsViewModel()
            {
                Id = 1,
                Name = "Jakakolwiek",
                Price = 200
            };
        }

        public void Add(ProductAddViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Save(ProductAddViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}