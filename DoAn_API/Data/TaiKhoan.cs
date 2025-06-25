using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class TaiKhoan
    {
        [Key]
        public Guid ID_TK { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string VaiTro { get; set; } = "KhachHang";
        public int TrangThai { get; set; }
        public DateTime NgayTao { get; set; } = DateTime.Now;

        public ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
