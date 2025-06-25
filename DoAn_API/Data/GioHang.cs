using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class GioHang
    {
        [Key]
        public Guid ID_GioHang { get; set; }
        public DateTime NgayTao { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<GioHangCT> GioHangCTs { get; set; }
    }
}
