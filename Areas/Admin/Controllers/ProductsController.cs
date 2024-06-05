using Microsoft.AspNetCore.Mvc;

namespace ecommerceWithAngular.Areas.Admin.Controllers;
[Area("Admin")]

    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }

