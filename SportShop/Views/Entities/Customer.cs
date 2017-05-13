using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportShop.Views.Entities
{
    public enum Sex
    {
        Male, 
        Female,
        Unknown
    }
    public class Customer
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Sex Sex { get; set; }

        public string Phone { get; set; }

    }
}