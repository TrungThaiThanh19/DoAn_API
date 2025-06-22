using Microsoft.AspNetCore.Mvc;

namespace DoAn_MVC.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
