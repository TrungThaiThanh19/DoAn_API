using DoAn_API.Data;
using System.ComponentModel.DataAnnotations;

public class PhuongThucThanhToan
{
    [Key]
    public Guid ID_ThanhToan { get; set; }
    public string TenPT { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; }
}
