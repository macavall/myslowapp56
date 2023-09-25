using Microsoft.AspNetCore.Mvc;

namespace myslowapp56.Controllers
{
    public class SlowTestTwoController : Controller
    {
        public async  Task<IActionResult> Index()
        {
            await Task.Delay(5000);

            return View();
        }
    }
}
