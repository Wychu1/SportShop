using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportShop.Models
{
    public class CustomerEditViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}