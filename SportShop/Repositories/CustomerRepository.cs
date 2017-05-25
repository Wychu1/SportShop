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
                Name = x.Name + " " + x.LastName,
                LastName = x.LastName,
                Phone = x.Phone,
                Email = x.Email

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

        public void Edit(Customer model)
        {
            var customer = new Customer
            {
                Name = model.Name,
                LastName = model.LastName,
                Email = model.Email,
                Sex = model.Sex,
                Phone = model.Phone
            };

            
        }

        public CustomerEditViewModel Get(long Id)
        {
            return _dbContext.Customers.Where(x => x.Id == Id)
                .Select(x => new CustomerEditViewModel
                {
                    Id = x.Id,
                    LastName = x.LastName,
                    Name = x.Name,
                    Phone = x.Phone
                })
                .Single();
        }

        public void Update(CustomerEditViewModel model)
        {
            var customer = _dbContext.Customers.Single(x => x.Id == model.Id);

            customer.LastName = model.LastName;
            customer.Name = model.Name;
            customer.Phone = model.Phone;

            _dbContext.SaveChanges();
        }

        public void Delete(long Id)
        {
            //var deleteCustomer = _dbContext.Customers.Find(Id);
            //var customer = _dbContext.Customers;

            //customer.Remove(deleteCustomer);
            //

            var customer = _dbContext.Customers.Single(x => x.Id == Id);
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
        }
    }
}