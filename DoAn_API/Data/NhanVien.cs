using DoAn_API.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class NhanVien
{
    [Key]
    public Guid ID_NV { get; set; }

    [Required(ErrorMessage = "Tên nhân viên không thể để trống.")]
    [StringLength(100, ErrorMessage = "Tên nhân viên không thể quá 100 ký tự.")]
    public string TenNV { get; set; }

    [StringLength(200, ErrorMessage = "Địa chỉ không thể quá 200 ký tự.")]
    public string DiaChi { get; set; }

    [Required(ErrorMessage = "Số CCCD không thể để trống.")]
    [StringLength(12, MinimumLength = 9, ErrorMessage = "Số CCCD phải có từ 9 đến 12 ký tự.")]
    public string SoCccd { get; set; }

    [Required(ErrorMessage = "Mật khẩu không thể để trống.")]
    [StringLength(100, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
    public string MatKhau { get; set; }

    [Required(ErrorMessage = "Vai trò không thể để trống.")]
    public string VaiTro { get; set; }

    [Required(ErrorMessage = "Trang thái không thể để trống.")]
    public string TrangThai { get; set; }

    public DateTime NgayTao { get; set; }
    public DateTime? NgayCapNhat { get; set; }

    public Guid? ID_TK { get; set; }
    [ForeignKey("ID_TK")]
    public TaiKhoan TaiKhoan { get; set; }

    public ICollection<HoaDon>? HoaDons { get; set; }
    public ICollection<PhieuNhap>? PhieuNhaps { get; set; }
}
