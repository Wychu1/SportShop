using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.DAL;
using SportShop.Models;
using SportShop.Views.Entities;

namespace SportShop.Repositories
{
    public class CategoriesRepository: ICategoryRepository
    {
        private readonly SportShopContext _dbContext;

        public CategoriesRepository(SportShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CategoryViewModel> GetCategories()
        {
            return _dbContext.Categories.Select(c => new CategoryViewModel
            {
                Name = c.Name,
                Id = c.Id
            });
        }
    }

}