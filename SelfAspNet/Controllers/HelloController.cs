using Microsoft.AspNetCore.Mvc;
using SelfAspNet.Models;

namespace SelfAspNet.Controllers
{
    public class HelloController : Controller
    {
        private readonly MyContext _db;

        public HelloController(MyContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return Content("Hello World!");
        }

        public IActionResult List()
        {
            var books = _db.Books;
            return View(books);
        }

        public IActionResult Show()
        {
            ViewBag.Message = "Hello World!";
            return View();
        }
    }
}
