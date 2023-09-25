using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace myslowapp56.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlowController : ControllerBase
    {
        [HttpGet]
        public async Task<string> SlowResponse()
        {
            await Task.Delay(5000);
            return "Complete";
        }
    }
}
