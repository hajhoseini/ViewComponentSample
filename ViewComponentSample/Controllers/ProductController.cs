using Microsoft.AspNetCore.Mvc;

namespace ViewComponentSample.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
