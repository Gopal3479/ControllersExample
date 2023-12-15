using Microsoft.AspNetCore.Mvc;

namespace ControllersExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();// if we dont specfy the view by defaultly it will take Index.cshtml
            //Views/Home/Index.cshtml
        }
    }
}
