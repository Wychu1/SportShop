using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportShop.Models;
using SportShop.Repositories;

namespace SportShop.Controllers
{
    public class CustomerController : Controller
    {

        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var customers = _repository.GetCustomers();

            return View(customers);



        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new AddCustomerViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(AddCustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Save(model);
                return RedirectToAction("List");
            }

            return View(model);
        }
    
}


}