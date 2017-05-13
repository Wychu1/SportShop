using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SportShop.Models
{
    public class ProductGridViewModel
    {
        
        public long Id { get; set; }
        
        public decimal Price { get; set; }
        
        public string Name { get; set; }
    }
}