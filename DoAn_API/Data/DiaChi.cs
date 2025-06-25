using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class DiaChi
    {
        [Key]
        public Guid ID_DiaChi { get; set; }
        public Guid ID_NguoiDung { get; set; }
        public string TenDC { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
