using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace DoAn_API.Data
{
    public class ChiTietSanPham
    {
        [Key]
        public Guid ID_CTSP { get; set; }
        public Guid ID_SP { get; set; }
        public Guid ID_ThuTich { get; set; }
        public int SoLuongTon { get; set; }

        public virtual SanPham SanPham { get; set; }
        public virtual TheTich ThuTich { get; set; }
        public virtual ICollection<GioHangCT> GioHangCTs { get; set; }
        public virtual ICollection<HoaDonChiTiet> CTHoaDons { get; set; }
    }
}
