using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SportShop.Views.Entities;

namespace SportShop.Models
{
    public class EditCustomerViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Sex Sex { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}