﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.Models;

namespace SportShop.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable<CustomerGridViewModel> GetCustomers();
        void Save(AddCustomerViewModel model);
        CustomerEditViewModel Get(long Id);
        void Update(CustomerEditViewModel model);
        void Delete(long Id);
    }
}