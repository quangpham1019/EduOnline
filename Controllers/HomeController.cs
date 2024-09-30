using Microsoft.AspNetCore.Mvc;

namespace EduOnline.Controllers
{
    public class HomeController : Controller
    {

        // Action == Request Handler's Name
        public string Index()
        {
            return "Hello World from Action Method";
        }

        public string Error()
        {
            return "I have an error here.";
        }
    }
}
