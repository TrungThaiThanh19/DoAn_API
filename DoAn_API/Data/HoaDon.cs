using DoAn_API.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq; // Đảm bảo đã thêm thư viện này để sử dụng LINQ

public class HoaDon
{
    [Key]
    public Guid ID_HD { get; set; }
    public Guid ID_NguoiDung { get; set; }
    public Guid ID_VCH { get; set; }
    public Guid ID_ThanhToan { get; set; }
    public Guid ID_VanChuyen { get; set; }
    public Guid ID_DiaChi { get; set; }

    public string TenKH { get; set; }
    public string Sdt { get; set; }
    public decimal TongTien { get; set; }
    public int TrangThai { get; set; }
    public DateTime NgayTao { get; set; }

    public virtual NguoiDung NguoiDung { get; set; }
    public virtual Voucher Voucher { get; set; }
    public virtual PhuongThucThanhToan ThanhToan { get; set; }
    public virtual PhuongThucVanChuyen VanChuyen { get; set; }
    public virtual DiaChi DiaChi { get; set; }

    public virtual ICollection<HoaDonChiTiet> CTHoaDons { get; set; }
}
