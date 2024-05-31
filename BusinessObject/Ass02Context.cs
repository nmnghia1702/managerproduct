using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject;

public partial class Ass02Context : DbContext
{
    public Ass02Context()
    {
    }

    public Ass02Context(DbContextOptions<Ass02Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        optionsBuilder.UseSqlServer(config.GetConnectionString("MyCnn"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Member__0CF04B187D986F5B");

            entity.ToTable("Member");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.CompanyName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Order__C3905BCF8E8E9D3D");

            entity.ToTable("Order");

            entity.Property(e => e.Freight).HasColumnType("money");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.RequiredDate).HasColumnType("datetime");
            entity.Property(e => e.ShippedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Member).WithMany(p => p.Orders)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK__Order__MemberId__286302EC");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            // Xác định bảng OrderDetail có khóa chính gồm ProductId và OrderId
            entity.HasKey(e => new { e.ProductId, e.OrderId }).HasName("PK_OrderDetail");

            // Tiếp tục các cài đặt khác cho bảng OrderDetail
            entity.ToTable("OrderDetail");
            entity.HasIndex(e => new { e.ProductId, e.OrderId }, "UC_OrderDetail_ProductId_OrderId").IsUnique();
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.HasOne(d => d.Order).WithMany().HasForeignKey(d => d.OrderId).HasConstraintName("FK__OrderDeta__Order__2A4B4B5E");
            entity.HasOne(d => d.Product).WithMany().HasForeignKey(d => d.ProductId).HasConstraintName("FK__OrderDeta__Produ__2B3F6F97");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CDE4CED029");

            entity.ToTable("Product");

            entity.Property(e => e.ProductName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.UnitPrice).HasColumnType("money");
            entity.Property(e => e.Weight)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
