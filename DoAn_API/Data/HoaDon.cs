using DoAn_API.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq; // Đảm bảo đã thêm thư viện này để sử dụng LINQ

public class HoaDon
{
    [Key]
    public Guid ID_HD { get; set; }

    [Required]
    public DateTime NgayLap { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Tổng tiền phải lớn hơn 0.")]
    public decimal TongTien { get; set; }

    public string TrangThai { get; set; } = "Pending"; // Default trạng thái là "Pending"

    public DateTime NgayTao { get; set; }
    public DateTime? NgayCapNhat { get; set; }
    public string NguoiTao { get; set; }
    public string NguoiCapNhat { get; set; }

    public Guid ID_KH { get; set; }
    public Guid ID_NV { get; set; }
    public Guid? ID_VCH { get; set; }

    [ForeignKey("ID_KH")]
    public KhachHang KhachHang { get; set; }

    [ForeignKey("ID_NV")]
    public NhanVien NhanVien { get; set; }

    [ForeignKey("ID_VCH")]
    public Voucher Voucher { get; set; }

    public ICollection<HoaDonChiTiet>? CTHoaDons { get; set; }

    // Tính toán tự động tổng tiền
    [NotMapped]
    public decimal CalculatedTongTien => CTHoaDons?.Sum(ct => ct.SoLuong * ct.Gia) ?? 0;
}
