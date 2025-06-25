using DoAn_API.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class PhieuNhap
{
    [Key]
    public Guid ID_PN { get; set; }

    [Required]
    public DateTime NgayNhap { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Tổng tiền phải lớn hơn 0.")]
    public decimal TongTien { get; set; }

    public Guid? ID_NV { get; set; }

    [ForeignKey("ID_NV")]
    public NhanVien NhanVien { get; set; }

    public ICollection<ChiTietPhieuNhap>? CTPhieuNhaps { get; set; }
}
