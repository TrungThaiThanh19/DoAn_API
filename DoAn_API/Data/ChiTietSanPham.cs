using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DoAn_API.Data
{
    public class ChiTietSanPham
    {
        [Key]
        public Guid ID_CTSP { get; set; }
        public string HinhAnh { get; set; }
        public string TrangThai { get; set; }

        public Guid ID_SP { get; set; }
        public Guid ID_MS { get; set; }
        public Guid ID_SIZE { get; set; }
        public Guid ID_TH { get; set; }

        [ForeignKey("ID_SP")]
        public SanPham SanPham { get; set; }

        [ForeignKey("ID_MS")]
        public MauSac MauSac { get; set; }

        [ForeignKey("ID_SIZE")]
        public Size Size { get; set; }

        [ForeignKey("ID_TH")]
        public ThuongHieu ThuongHieu { get; set; }
    }
}
