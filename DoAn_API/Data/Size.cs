using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class Size
    {
        [Key]
        public Guid ID_SIZE { get; set; }
        public string TenSize { get; set; }
        public string TrangThai { get; set; }

        public ICollection<ChiTietSanPham>? CTSanPhams { get; set; }
    }
}
