using DoAn_API.Data;
using System.ComponentModel.DataAnnotations;

public class ThuongHieu
{
    [Key]
    public Guid ID_TH { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "Tên thương hiệu không thể quá 100 ký tự.")]
    public string TenTH { get; set; }

    [Required]
    public string TrangThai { get; set; } = "Active"; // Default trạng thái là "Active"

    public DateTime NgayTao { get; set; }
    public DateTime? NgayCapNhat { get; set; }

    public ICollection<ChiTietSanPham>? CTSanPhams { get; set; }
}
