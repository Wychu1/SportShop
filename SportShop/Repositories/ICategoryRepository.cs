using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.Models;

namespace SportShop.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryViewModel> GetCategories();
    }
}