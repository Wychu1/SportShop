﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportShop.Models
{
    public class ProductDetailsViewModel
    {
        public long Id { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}