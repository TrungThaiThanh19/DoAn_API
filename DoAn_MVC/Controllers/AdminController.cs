using Microsoft.AspNetCore.Mvc;

namespace DoAn_MVC.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var role = HttpContext.Session.GetString("VaiTro");
            if (role != "Admin")
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }
    }
}
