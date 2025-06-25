using DoAn_API.Data;
using System.ComponentModel.DataAnnotations;

public class SanPham
{
    [Key]
    public Guid ID_SP { get; set; }
    public string TenSP { get; set; }
    public string ThuongHieu { get; set; }
    public string GioiThieu { get; set; }
    public decimal DonGiaNhap { get; set; }
    public decimal DonGiaBan { get; set; }
    public string HinhAnh { get; set; }

    public virtual ICollection<ChiTietSanPham> CT_SanPhams { get; set; }
}
