using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using SportShop.DAL;
using SportShop.Models;
using SportShop.Repositories;
using SportShop.Views.Entities;

namespace SportShop.Controllers
{
    public class ProductController : Controller
    {
        
        //private readonly IProductRepository _repository = new ProductInMemoryRepository();

        //Nie musimy już tworzyć nowej instancji, odwołujemy się do kontenera.

        //Dependency Injection
        private readonly IProductRepository _repository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository repository, ICategoryRepository categoryRepository)
        {
            _repository = repository;
            _categoryRepository = categoryRepository;
        }


        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult List()
        {
            //using (var db = new SportShopContext())
            //{
            //    var customer = new Customer
            //    {
            //        Email = "sds",
            //        LastName = "asdas",
            //        Name = "asddsa",
            //        Phone = "123",
            //        Sex = Sex.Female
            //    };
            //    db.Customers.Add(customer);
            //    db.SaveChanges();
            //}

            var items = _repository.GetProducts();
            var model = new ProductGridModel()
            {
                Items = items,
                Count = items.Count()
            };
            return View(model);
        }

        public ActionResult GetProduct(long productId)
        {
            var model = _repository.Get(productId);
            return View(model);
        }

        [HttpPost]
        public ActionResult GetProduct(ProductDetailsViewModel model)
        {

            //AddModelError

            //if (model.Price % 4 != 0)
            //{
            //    ModelState.AddModelError(nameof(ProductDetailsViewModel.Price), "Zła wartość");
            //}

            if (ModelState.IsValid)

            {
                return RedirectToAction("List");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Categories = _categoryRepository.GetCategories()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(ProductAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(model);
                return RedirectToAction("List");
            }
            model.Categories = _categoryRepository.GetCategories();
            return View(model);
        }

    }

    public class ProductGridModel
    {
        public long Count { get; set; }

        public IEnumerable<ProductGridViewModel> Items { get; set; }
    }
    

}