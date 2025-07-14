using Microsoft.EntityFrameworkCore;
using QLTDN5.Entities;

namespace QLTDN5.Data
{
    public class QLTDN5Context : DbContext
    {
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<TramDien> TramDiens { get; set; }
        public DbSet<CongToDien> CongToDiens { get; set; }
        public DbSet<BangGia> BangGiaDiens { get; set; }
        public DbSet<ChiSoDien> ChiSoDiens { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-PID86FA;Database=QLTDN5;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Khóa chính
            modelBuilder.Entity<KhachHang>().HasKey(x => x.Id);
            modelBuilder.Entity<NhanVien>().HasKey(x => x.Id);
            modelBuilder.Entity<TramDien>().HasKey(x => x.Id);
            modelBuilder.Entity<CongToDien>().HasKey(x => x.Id);
            modelBuilder.Entity<BangGia>().HasKey(x => x.Id);
            modelBuilder.Entity<ChiSoDien>().HasKey(x => x.Id);
            modelBuilder.Entity<HoaDon>().HasKey(x => x.Id);

            // CongToDien ↔ KhachHang
            modelBuilder.Entity<CongToDien>()
                .HasOne(ct => ct.KhachHang)
                .WithMany(kh => kh.CongToDiens)
                .HasForeignKey(ct => ct.KhachHangId)
                .OnDelete(DeleteBehavior.Restrict);

            // ChiSoDien ↔ CongToDien
            modelBuilder.Entity<ChiSoDien>()
                .HasOne(cs => cs.CongToDien)
                .WithMany(ct => ct.ChiSoDiens)
                .HasForeignKey(cs => cs.CongToDienId)
                .OnDelete(DeleteBehavior.Restrict);

            //ChiSoDien ↔ KhachHang
            modelBuilder.Entity<ChiSoDien>()
               .HasOne(cs => cs.KhachHang)
               .WithMany(kh => kh.ChiSoDiens)
               .HasForeignKey(cs => cs.KhachHangId)
               .OnDelete(DeleteBehavior.Restrict);

            // HoaDon ↔ KhachHang
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.KhachHang)
                .WithMany(kh => kh.HoaDons)
                .HasForeignKey(h => h.KhachHangId)
                .OnDelete(DeleteBehavior.Restrict);

            // HoaDon ↔ ChiSoDien
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.ChiSoDien)
                .WithMany(cs => cs.HoaDons)
                .HasForeignKey(h => h.ChiSoDienId)
                .OnDelete(DeleteBehavior.Restrict);

            
            base.OnModelCreating(modelBuilder);
        }
    }
}