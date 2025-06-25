using DoAn_API.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class NguoiDung
{
    [Key]
    public Guid ID_NguoiDung { get; set; }

    [ForeignKey("TaiKhoan")]
    public Guid ID_TK { get; set; }
    public string TenND { get; set; }
    public string Sdt { get; set; }
    public string Email { get; set; }
    public DateTime NgayTao { get; set; }

    public TaiKhoan TaiKhoan { get; set; }
    public virtual ICollection<DiaChi> DiaChis { get; set; }
    public virtual ICollection<HoaDon> HoaDons { get; set; }
}
