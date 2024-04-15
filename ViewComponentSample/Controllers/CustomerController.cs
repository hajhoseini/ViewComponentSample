using Microsoft.AspNetCore.Mvc;

namespace ViewComponentSample.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
