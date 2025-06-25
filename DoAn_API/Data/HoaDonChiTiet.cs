using DoAn_API.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class HoaDonChiTiet
{
    [Key]
    public Guid ID_HDCT { get; set; }
    public Guid ID_HD { get; set; }
    public Guid ID_CTSP { get; set; }
    public decimal Gia { get; set; }
    public int SoLuong { get; set; }

    public virtual HoaDon HoaDon { get; set; }
    public virtual ChiTietSanPham CTSanPham { get; set; }
}
