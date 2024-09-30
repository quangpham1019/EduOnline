using Microsoft.AspNetCore.Mvc;

namespace EduOnline.Controllers
{
    public class HomeController : Controller
    {

        // Action == Request Handler's Name
        public IActionResult Index()
        {
            // By default, View() return the .cshtml file at Views/Home/Index.cshtml
            return View();
        }

    }
}
