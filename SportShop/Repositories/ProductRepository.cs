using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.DAL;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly SportShopContext _context;

        public ProductRepository(SportShopContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductGridViewModel> GetProducts()
        {
            return _context.Products.Select(x => new ProductGridViewModel
            {
                Id = x.Id,
                Name = x.Name,
                CategoryName = x.Category.Name,
                Description = x.Description,
                Price = x.Price
            }).ToList();
        }

        public ProductDetailsViewModel Get(long id)
        {
            return _context.Products.Where(x => x.Id == id).Select(x => new ProductDetailsViewModel
            {
                Description = x.Description,
                Id = x.Id,
                Price = x.Price,
                Name = x.Name
            }).Single();
        }

        public void Add(ProductAddViewModel model)
        {
            
        }
    }
}