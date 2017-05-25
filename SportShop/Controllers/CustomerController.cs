using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportShop.Models;
using SportShop.Repositories;
using SportShop.Views.Entities;

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

        public ActionResult Edit(long id)
        {
            var model = _repository.Get(id);

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(CustomerEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
                return RedirectToAction("List");
            }

            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(long id)
        {
            _repository.Delete(id);

            return RedirectToAction("List");
        }
    }


}