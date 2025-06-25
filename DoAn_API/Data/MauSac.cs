using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class MauSac
    {
        [Key]
        public Guid ID_MS { get; set; }
        public string TenMS { get; set; }
        public string TrangThai { get; set; }

        public ICollection<ChiTietSanPham> CTSanPhams { get; set; }
    }
}
