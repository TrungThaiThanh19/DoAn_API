using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class TheTich
    {
        [Key]
        public Guid ID_TheTich { get; set; }
        public string TenTheTich { get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }

        public virtual ICollection<ChiTietSanPham> CT_SanPhams { get; set; }
    }
}
