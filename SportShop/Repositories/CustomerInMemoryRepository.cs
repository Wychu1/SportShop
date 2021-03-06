﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class CustomerInMemoryRepository : ICustomerRepository
    {
        public IEnumerable<CustomerGridViewModel> GetCustomers()
        {
            return new[]
            {
                new CustomerGridViewModel
                {
                    Id = 1,
                    Name = "Wojtek",

                },

                new CustomerGridViewModel
                {
                    Id = 2,
                    Name = "Mariusz",

                },

                new CustomerGridViewModel
                {
                    Id = 3,
                    Name = "Shota",

                }
            };
        }

        public void Save(AddCustomerViewModel model)
        {
            throw new NotImplementedException();
        }

        public CustomerEditViewModel Get(long Id)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerEditViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(long Id)
        {
            throw new NotImplementedException();
        }
    }
}