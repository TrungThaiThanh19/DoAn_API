using DoAn_API.Data;
using System.ComponentModel.DataAnnotations;

public class KhachHang
{
    [Key]
    public Guid ID_KH { get; set; }

    [Required(ErrorMessage = "Số điện thoại không thể để trống.")]
    [Phone(ErrorMessage = "Số điện thoại không hợp lệ.")]
    public string SoDienThoai { get; set; }

    [Required(ErrorMessage = "Tên khách hàng không thể để trống.")]
    [StringLength(100, ErrorMessage = "Tên khách hàng không thể quá 100 ký tự.")]
    public string TenKhach { get; set; }

    [StringLength(200, ErrorMessage = "Địa chỉ không thể quá 200 ký tự.")]
    public string DiaChi { get; set; }
    public enum Gender
    {
        Male,
        Female,
        Other
    }
    public Gender? GioiTinh { get; set; }

    public ICollection<HoaDon>? HoaDons { get; set; }
}
