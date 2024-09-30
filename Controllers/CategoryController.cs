using EduOnline.Models;
using Microsoft.AspNetCore.Mvc;

namespace EduOnline.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Parameter will become default values if invalid arguments are passed in
        // Optional parameter is one way to handle improper input
        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };

            return View(category);
        }
    }
}
