using AspDOTNET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspDOTNET_MVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoryRepository.GetCategories();
            return View(categories);
        }

        // Parameter will become default values if invalid arguments are passed in
        // Optional parameter is one way to handle improper input
        public IActionResult Edit(int? id)
        {
            var category = CategoryRepository.GetCategoryById(id.HasValue ? id.Value : 0);

            return View(category);
        }
    }
}
