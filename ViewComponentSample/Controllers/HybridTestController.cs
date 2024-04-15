using Microsoft.AspNetCore.Mvc;

namespace ViewComponentSample.Controllers
{
    [ViewComponent(Name = "Test")]
    public class HybridTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Invoke()
        {
            return "";
        }
    }
}
