using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DATN_AspNetCore_WebBanSach.Areas.Identity.Data;
using DATN_AspNetCore_WebBanSach.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DATN_AspNetCore_WebBanSach.Data
{
    public class DATN_AspNetCore_WebBanSachContext : IdentityDbContext<DATN_AspNetCore_WebBanSachUser>
    {
        public DATN_AspNetCore_WebBanSachContext(DbContextOptions<DATN_AspNetCore_WebBanSachContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tablename = entityType.GetTableName();
                if (tablename.StartsWith("AspNet"))
                    entityType.SetTableName(tablename.Substring(6));
            }
            // Tạo Index cho cột Slug bảng Category
            builder.Entity<DanhMuc>(entity => {
                entity.HasIndex(p => p.TenDM);
            });
            builder.Entity<TinTuc>(entity => {
                entity.HasIndex(p => p.Link);
            });
            builder.Entity<Banner>(entity => {
                entity.HasIndex(p => p.TenBanner);
            });
            builder.Entity<BinhLuan>(entity => {
                entity.HasIndex(p => p.UsersId);
            });
            builder.Entity<GioHang>(entity => {
                entity.HasIndex(p => p.UsersId);
            });
            builder.Entity<HoaDon>(entity => {
                entity.HasIndex(p => p.MaHD);
            });
            builder.Entity<SanPham>(entity => {
                entity.HasIndex(p => p.MaSP);
            });
            builder.Entity<TacGia>(entity => {
                entity.HasIndex(p => p.TenTacGia);
            });
            builder.Entity<KhuyenMai>(entity => {
                entity.HasIndex(p => p.MaKM);
            });
            builder.Entity<ThongBao>(entity => {
                entity.HasIndex(p => p.UsersId);
            });
            builder.Entity<NhaXuatBan>(entity => {
                entity.HasIndex(p => p.MaNXB);
            });
            builder.Entity<ChiTietHoaDon>(entity => {
                entity.HasIndex(p => p.HoaDonId);
            });
            builder.Entity<TacGiaSanPham>(entity => {
                entity.HasKey(p => new { p.SanPhamId, p.TacGiaId });
            });
        }
        public List<TinTuc> TinTucs { get; set; }
        public List<Banner> Banners { get; set; }
        public List<BinhLuan> BinhLuans { get; set; }
        public List<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public List<DanhMuc> DanhMucs { get; set; }
        public List<GioHang> GioHangs { get; set; }
        public List<HinhAnh> HinhAnhs { get; set; }
        public List<HoaDon> HoaDons { get; set; }
        public List<KhuyenMai> KhuyenMais { get; set; }
        public List<NhaXuatBan> NhaXuatBans { get; set; }
        public List<SanPham> SanPhams { get; set; }
        public List<TacGia> TacGias { get; set; }
        public List<TacGiaSanPham> TacGiaSanPhams { get; set; }
        public List<ThongBao> ThongBaos { get; set; }
    }
}
