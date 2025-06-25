using DoAn_API.Data;
using DoAn_API.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DoAn_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private readonly DoAnDbContext _context;
        public TaiKhoanController(DoAnDbContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            if (_context.TaiKhoans.Any(x => x.UserName == dto.UserName))
                return BadRequest("Tài khoản đã tồn tại");

            var tk = new TaiKhoan
            {
                UserName = dto.UserName,
                PassWord = dto.PassWord,
                VaiTro = "KhachHang",
                TrangThai = 1,
                NgayTao = DateTime.Now
            };
            _context.TaiKhoans.Add(tk);
            _context.SaveChanges();

            var nd = new NguoiDung
            {
                ID_TK = tk.ID_TK,
                TenND = dto.TenND,
                Email = dto.Email,
                Sdt = dto.Sdt,
                NgayTao = DateTime.Now
            };
            _context.NguoiDungs.Add(nd);
            _context.SaveChanges();

            return Ok("Đăng ký thành công");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            var tk = _context.TaiKhoans.FirstOrDefault(x =>
                x.UserName == dto.UserName &&
                x.PassWord == dto.PassWord &&
                x.TrangThai == 1);

            if (tk == null)
                return Unauthorized("Sai tên đăng nhập hoặc mật khẩu");

            return Ok(new { id_TK = tk.ID_TK, vaiTro = tk.VaiTro });
        }
    }
}
