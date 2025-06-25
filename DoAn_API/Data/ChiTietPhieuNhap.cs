using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class ChiTietPhieuNhap
    {
        [Key]
        public Guid ID_CTPN { get; set; }
        public decimal Gia { get; set; }
        public int SoLuongNhap { get; set; }

        public Guid ID_PN { get; set; }
        public Guid ID_SP { get; set; }

        [ForeignKey("ID_PN")]
        public PhieuNhap PhieuNhap { get; set; }

        [ForeignKey("ID_SP")]
        public SanPham SanPham { get; set; }
    }
}
