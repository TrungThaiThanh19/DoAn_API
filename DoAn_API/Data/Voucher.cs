using System.ComponentModel.DataAnnotations;

public class Voucher
{
    [Key]
    public Guid ID_VCH { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Tên voucher không thể quá 100 ký tự.")]
    public string TenVch { get; set; }

    [Required]
    [Range(0.01, 100, ErrorMessage = "Phần trăm giảm phải trong khoảng từ 0 đến 100.")]
    public decimal PhanTramGiam { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Số lượng voucher phải lớn hơn 0.")]
    public int SoLuong { get; set; }

    public DateTime NgayTao { get; set; }
    public string NguoiTao { get; set; }
    public DateTime? NgayCapNhat { get; set; }
    public string? NguoiCapNhat { get; set; }
    public DateTime HanSuDung { get; set; }

    [Required]
    public string TrangThai { get; set; } = "Active"; // Default trạng thái là "Active"

    public ICollection<HoaDon>? HoaDons { get; set; }
}
