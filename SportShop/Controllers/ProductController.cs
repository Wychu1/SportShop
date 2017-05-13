using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using SportShop.Models;
using SportShop.Repositories;

namespace SportShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository = new ProductInMemoryRepository();
        // GET: Product


        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult List()
        {
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
    }

    public class ProductGridModel
    {
        public long Count { get; set; }

        public IEnumerable<ProductGridViewModel> Items { get; set; }
    }

}