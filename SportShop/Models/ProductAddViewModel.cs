using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SportShop.Views.Entities;

namespace SportShop.Models
{

    //łącznik między widokiem a bazą danych
    public class ProductAddViewModel
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category CategoryId { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}