using DoAn_API.Data;
using System.ComponentModel.DataAnnotations;

public class GioHangCT
{
    [Key]
    public Guid ID_GioHangCT { get; set; }
    public Guid ID_GioHang { get; set; }
    public Guid ID_SPCT { get; set; }
    public int SoLuong { get; set; }
    public decimal Gia { get; set; }
    public decimal TongTien { get; set; }

    public virtual GioHang GioHang { get; set; }
    public virtual ChiTietSanPham CTSanPham { get; set; }
}
