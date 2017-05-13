using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportShop.Views.Entities
{
    public class Product
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }


        // virtual jeśli jako właściwość podajemy inną encję, np. Category w Product
        public virtual Category Category { get; set; }

    }
}