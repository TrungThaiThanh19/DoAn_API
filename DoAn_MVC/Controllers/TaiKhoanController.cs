using DoAn_MVC.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoAn_MVC.Controllers
{
    public class TaiKhoanController : Controller
    {

        private readonly HttpClient _httpClient;
        public TaiKhoanController(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("ApiClient");
        }
        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var res = await _httpClient.PostAsJsonAsync("api/taikhoan/login", dto);
            if (res.IsSuccessStatusCode)
            {
                var data = await res.Content.ReadFromJsonAsync<LoginResult>();
                string role = data?.vaiTro;
                Guid id = data.id_TK;

                HttpContext.Session.SetString("VaiTro", role);
                HttpContext.Session.SetString("ID_TK", id.ToString());

                if (role == "Admin")
                    return RedirectToAction("Index", "Admin");
                else
                    return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Sai tên đăng nhập hoặc mật khẩu";
            return View();
        }

        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var res = await _httpClient.PostAsJsonAsync("api/taikhoan/register", dto);
            if (res.IsSuccessStatusCode)
            {
                return RedirectToAction("Login");
            }

            ViewBag.Error = await res.Content.ReadAsStringAsync();
            return View();
        }

    }
}
