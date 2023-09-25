using Microsoft.AspNetCore.Mvc;

namespace myslowapp56.Controllers
{
    public class SlowTestOneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
