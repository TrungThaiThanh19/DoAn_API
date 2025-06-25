using Microsoft.EntityFrameworkCore;

namespace DoAn_API.Data
{
    public class DoAnDbContext : DbContext
    {
        public DoAnDbContext() { }

        public DoAnDbContext(DbContextOptions options) : base(options) { }

        // DbSet cho các bảng
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<NguoiDung> NguoiDungs { get; set; }
        public DbSet<DiaChi> DiaChis { get; set; }
        public DbSet<PhuongThucThanhToan> PhuongThucThanhToans { get; set; }
        public DbSet<PhuongThucVanChuyen> PhuongThucVanChuyens { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<TheTich> TheTichs { get; set; }
        public DbSet<ChiTietSanPham> CTSanPhams { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangCT> GioHangCTs { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> CTHoaDons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TaiKhoan - NguoiDung
            modelBuilder.Entity<NguoiDung>()
                .HasOne(nd => nd.TaiKhoan)
                .WithMany(tk => tk.NguoiDungs)
                .HasForeignKey(nd => nd.ID_TK)
                .OnDelete(DeleteBehavior.Restrict);

            // NguoiDung - DiaChi
            modelBuilder.Entity<DiaChi>()
                .HasOne(dc => dc.NguoiDung)
                .WithMany(nd => nd.DiaChis)
                .HasForeignKey(dc => dc.ID_NguoiDung);

            // NguoiDung - HoaDon
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.NguoiDung)
                .WithMany(nd => nd.HoaDons)
                .HasForeignKey(hd => hd.ID_NguoiDung)
                .OnDelete(DeleteBehavior.Restrict);

            // Voucher - HoaDon
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.Voucher)
                .WithMany(v => v.HoaDons)
                .HasForeignKey(hd => hd.ID_VCH)
                .OnDelete(DeleteBehavior.Restrict);

            // PhuongThucThanhToan - HoaDon
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.ThanhToan)
                .WithMany(pt => pt.HoaDons)
                .HasForeignKey(hd => hd.ID_ThanhToan);

            // PhuongThucVanChuyen - HoaDon
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.VanChuyen)
                .WithMany(vc => vc.HoaDons)
                .HasForeignKey(hd => hd.ID_VanChuyen);

            // DiaChi - HoaDon
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.DiaChi)
                .WithMany(dc => dc.HoaDons)
                .HasForeignKey(hd => hd.ID_DiaChi);

            // HoaDon - CTHoaDon
            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.CTHoaDons)
                .HasForeignKey(ct => ct.ID_HD);

            // CTSanPham - CTHoaDon
            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(ct => ct.CTSanPham)
                .WithMany(ctsp => ctsp.CTHoaDons)
                .HasForeignKey(ct => ct.ID_CTSP);

            // SanPham - CTSanPham
            modelBuilder.Entity<ChiTietSanPham>()
                .HasOne(ctsp => ctsp.SanPham)
                .WithMany(sp => sp.CT_SanPhams)
                .HasForeignKey(ctsp => ctsp.ID_SP);

            // ThuTich - CTSanPham
            modelBuilder.Entity<ChiTietSanPham>()
                .HasOne(ctsp => ctsp.ThuTich)
                .WithMany(tt => tt.CT_SanPhams)
                .HasForeignKey(ctsp => ctsp.ID_ThuTich);

            // GioHang - GioHangCT
            modelBuilder.Entity<GioHangCT>()
                .HasOne(ct => ct.GioHang)
                .WithMany(g => g.GioHangCTs)
                .HasForeignKey(ct => ct.ID_GioHang);

            // CTSanPham - GioHangCT
            modelBuilder.Entity<GioHangCT>()
                .HasOne(ct => ct.CTSanPham)
                .WithMany(ctsp => ctsp.GioHangCTs)
                .HasForeignKey(ct => ct.ID_SPCT);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8CVDJNS6;Database=DATN1;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
