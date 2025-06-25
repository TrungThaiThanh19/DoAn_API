using DoAn_API.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class HoaDonChiTiet
{
    [Key]
    public Guid ID_HDCT { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0.")]
    public int SoLuong { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0.")]
    public decimal Gia { get; set; }

    public Guid ID_HD { get; set; }
    public Guid ID_SP { get; set; }

    [ForeignKey("ID_HD")]
    public HoaDon HoaDon { get; set; }

    [ForeignKey("ID_SP")]
    public SanPham SanPham { get; set; }

    [NotMapped]
    public decimal ThanhTien => SoLuong * Gia;
}
