using Microsoft.AspNetCore.Mvc;

namespace SelfAspNet.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World!");
        }

        public IActionResult Show()
        {
            ViewBag.Message = "Hello World!";
            return View();
        }
    }
}
