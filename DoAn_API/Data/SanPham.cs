using DoAn_API.Data;
using System.ComponentModel.DataAnnotations;

public class SanPham
{
    [Key]
    public Guid ID_SP { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Tên sản phẩm không thể quá 100 ký tự.")]
    public string TenSP { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Giá sản phẩm phải lớn hơn 0.")]
    public decimal Gia { get; set; }

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "Số lượng tồn phải lớn hơn hoặc bằng 0.")]
    public int SoLuongTon { get; set; }

    public string TrangThai { get; set; } = "Available"; // Default trang thái là "Available"

    public ICollection<ChiTietSanPham>? CTSanPhams { get; set; }
    public ICollection<HoaDonChiTiet>? CTHoaDons { get; set; }
    public ICollection<ChiTietPhieuNhap>? CTPhieuNhaps { get; set; }
}
