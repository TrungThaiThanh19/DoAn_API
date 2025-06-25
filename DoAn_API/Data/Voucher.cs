using System.ComponentModel.DataAnnotations;

public class Voucher
{
    [Key]
    public Guid ID_VCH { get; set; }
    public decimal PhanTramGiam { get; set; }
    public int SoLuong { get; set; }
    public DateTime NgayBatDau { get; set; }
    public DateTime NgaySua { get; set; }
    public DateTime NgayKetThuc { get; set; }
    public string NguoiSua { get; set; }
    public int TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; }
}
