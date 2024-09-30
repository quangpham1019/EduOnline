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
            if (id.HasValue)
            {
                return new ContentResult { Content = id.ToString() };
            } else
            {
                return new ContentResult { Content = "null content" };
            }
        }
    }
}
