using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Fibon.Service.Controllers
{
    
    public class HomeController : Controller{


        [HttpGet("")]
        public IActionResult Get(){
            return Content("Hello from FIBON Service.");
        }
    }
}