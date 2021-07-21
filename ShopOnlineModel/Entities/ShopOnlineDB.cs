using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShopOnlineModel.Entities
{
    public partial class ShopOnlineDB : DbContext
    {
        public ShopOnlineDB()
            : base("name=ShopOnlineDB")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<GroupDetail> GroupDetails { get; set; }
        public virtual DbSet<GroupPr> GroupPrs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductDetail> ProductDetails { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.passWord)
                .IsUnicode(false);

            modelBuilder.Entity<GroupDetail>()
                .Property(e => e.maLoaiSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<GroupDetail>()
                .Property(e => e.nhomMa)
                .IsUnicode(false);

            modelBuilder.Entity<GroupDetail>()
                .Property(e => e.meta_tittle)
                .IsUnicode(false);

            modelBuilder.Entity<GroupDetail>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.GroupDetail)
                .HasForeignKey(e => e.loaiSanPhamMa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GroupPr>()
                .Property(e => e.maNhom)
                .IsUnicode(false);

            modelBuilder.Entity<GroupPr>()
                .Property(e => e.meta_tittle)
                .IsUnicode(false);

            modelBuilder.Entity<GroupPr>()
                .HasMany(e => e.GroupDetails)
                .WithRequired(e => e.GroupPr)
                .HasForeignKey(e => e.nhomMa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.loaiSanPhamMa)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.urlAnh)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductDetail>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<ProductDetail>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<ProductDetail>()
                .HasMany(e => e.ReceiptDetails)
                .WithRequired(e => e.ProductDetail)
                .HasForeignKey(e => new { e.maSanPham, e.size })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.userEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.ReceiptDetails)
                .WithRequired(e => e.Receipt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReceiptDetail>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiptDetail>()
                .Property(e => e.size)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.soDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Receipts)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.userEmail)
                .WillCascadeOnDelete(false);
        }
    }
}
