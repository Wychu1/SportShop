using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.DAL;
using SportShop.Models;
using SportShop.Views.Entities;

namespace SportShop.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SportShopContext _dbContext;

        public CustomerRepository(SportShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CustomerGridViewModel> GetCustomers()
        {
            return _dbContext.Customers.Select(x => new CustomerGridViewModel
            {
                Id = x.Id,
                Name = x.Name + " " + x.LastName
            });
        }

        public void Save(AddCustomerViewModel model)
        {
            var customer = new Customer
            {
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                Phone = model.Phone,
                Sex = model.Sex
            };

            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }
    }
}