using Microsoft.EntityFrameworkCore;

namespace DoAn_API.Data
{
    public class DoAnDbContext : DbContext
    {
        public DoAnDbContext()
        {

        }
        public DoAnDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> CTHoaDons { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<ChiTietSanPham> CTSanPhams { get; set; }
        public DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public DbSet<ChiTietPhieuNhap> CTPhieuNhaps { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ThuongHieu> ThuongHieus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // 1. KhachHang - HoaDon (1-n)
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.KhachHang)
                .WithMany(k => k.HoaDons)
                .HasForeignKey(h => h.ID_KH)
                .OnDelete(DeleteBehavior.Restrict);

            // 2. NhanVien - HoaDon (1-n)
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.NhanVien)
                .WithMany(nv => nv.HoaDons)
                .HasForeignKey(h => h.ID_NV)
                .OnDelete(DeleteBehavior.Restrict);

            // 3. Voucher - HoaDon (1-n)
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.Voucher)
                .WithMany(v => v.HoaDons)
                .HasForeignKey(h => h.ID_VCH)
                .OnDelete(DeleteBehavior.Restrict);

            // 4. HoaDon - CTHoaDon (1-n)
            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.CTHoaDons)
                .HasForeignKey(ct => ct.ID_HD)
                .OnDelete(DeleteBehavior.Cascade);

            // 5. SanPham - CTHoaDon (1-n)
            modelBuilder.Entity<HoaDonChiTiet>()
                .HasOne(ct => ct.SanPham)
                .WithMany(sp => sp.CTHoaDons)
                .HasForeignKey(ct => ct.ID_SP)
                .OnDelete(DeleteBehavior.Restrict);

            // 6. SanPham - CTSanPham (1-n)
            modelBuilder.Entity<ChiTietSanPham>()
                .HasOne(ct => ct.SanPham)
                .WithMany(sp => sp.CTSanPhams)
                .HasForeignKey(ct => ct.ID_SP)
                .OnDelete(DeleteBehavior.Cascade);

            // 7. MauSac - CTSanPham (1-n)
            modelBuilder.Entity<ChiTietSanPham>()
                .HasOne(ct => ct.MauSac)
                .WithMany(ms => ms.CTSanPhams)
                .HasForeignKey(ct => ct.ID_MS)
                .OnDelete(DeleteBehavior.Restrict);

            // 8. Size - CTSanPham (1-n)
            modelBuilder.Entity<ChiTietSanPham>()
                .HasOne(ct => ct.Size)
                .WithMany(sz => sz.CTSanPhams)
                .HasForeignKey(ct => ct.ID_SIZE)
                .OnDelete(DeleteBehavior.Restrict);

            // 9. ThuongHieu - CTSanPham (1-n)
            modelBuilder.Entity<ChiTietSanPham>()
                .HasOne(ct => ct.ThuongHieu)
                .WithMany(th => th.CTSanPhams)
                .HasForeignKey(ct => ct.ID_TH)
                .OnDelete(DeleteBehavior.Restrict);

            // 10. NhanVien - PhieuNhap (1-n)
            modelBuilder.Entity<PhieuNhap>()
                .HasOne(pn => pn.NhanVien)
                .WithMany(nv => nv.PhieuNhaps)
                .HasForeignKey(pn => pn.ID_NV)
                .OnDelete(DeleteBehavior.Restrict);

            // 11. PhieuNhap - CTPhieuNhap (1-n)
            modelBuilder.Entity<ChiTietPhieuNhap>()
                .HasOne(ct => ct.PhieuNhap)
                .WithMany(pn => pn.CTPhieuNhaps)
                .HasForeignKey(ct => ct.ID_PN)
                .OnDelete(DeleteBehavior.Cascade);

            // 12. SanPham - CTPhieuNhap (1-n)
            modelBuilder.Entity<ChiTietPhieuNhap>()
                .HasOne(ct => ct.SanPham)
                .WithMany(sp => sp.CTPhieuNhaps)
                .HasForeignKey(ct => ct.ID_SP)
                .OnDelete(DeleteBehavior.Restrict);

            // 13. NhanVien - TaiKhoan (n-1)
            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.TaiKhoan)
                .WithMany(tk => tk.NhanViens)
                .HasForeignKey(nv => nv.ID_TK)
                .OnDelete(DeleteBehavior.Restrict);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0O61DM6\\TRUNGTT;Database=DOAN;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}
