using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Dohuykhanh.App_Start
{
    public partial class Rubiks : DbContext
    {
        public Rubiks()
            : base("name=Rubiks")
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<Rubik> Rubik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.tendangnhap)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<Rubik>()
                .Property(e => e.gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Rubik>()
                .Property(e => e.hinh)
                .IsUnicode(false);

            modelBuilder.Entity<Rubik>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.Rubik)
                .WillCascadeOnDelete(false);
        }
    }
}
