using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class PhuongThucVanChuyen
    {
        [Key]
        public Guid ID_VanChuyen { get; set; }
        public string TenPT { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
