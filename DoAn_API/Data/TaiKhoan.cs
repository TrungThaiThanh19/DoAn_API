using System.ComponentModel.DataAnnotations;

namespace DoAn_API.Data
{
    public class TaiKhoan
    {
        [Key]
        public Guid ID_TK { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<NhanVien>? NhanViens { get; set; }
    }
}
