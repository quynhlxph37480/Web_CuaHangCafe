﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_CuaHangCafe.Data;

#nullable disable

namespace Web_CuaHangCafe.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240106101118_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbChiTietHoaDonBan", b =>
                {
                    b.Property<int>("MaSanPham")
                        .HasColumnType("int");

                    b.Property<Guid>("MaHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("GiaBan")
                        .HasColumnType("money");

                    b.Property<int?>("GiamGia")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal?>("ThanhTien")
                        .HasColumnType("money");

                    b.HasKey("MaSanPham", "MaHoaDon")
                        .HasName("PK__tbChiTie__52F2A93ED9FFE6AD");

                    b.HasIndex("MaHoaDon");

                    b.ToTable("tbChiTietHoaDonBan", (string)null);
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbHoaDonBan", b =>
                {
                    b.Property<Guid>("MaHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("NgayBan")
                        .HasColumnType("datetime");

                    b.Property<string>("SoHoaDon")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<decimal?>("TongTien")
                        .HasColumnType("money");

                    b.HasKey("MaHoaDon")
                        .HasName("PK__tbHoaDon__835ED13BE78BDB82");

                    b.HasIndex("CustomerId");

                    b.HasIndex(new[] { "SoHoaDon" }, "UQ__tbHoaDon__012E9E53087434A1")
                        .IsUnique();

                    b.ToTable("tbHoaDonBan", (string)null);
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbKhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SdtkhachHang")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("SDTKhachHang");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__tbKhachH__3214EC0779854367");

                    b.ToTable("tbKhachHang", (string)null);
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbNhomSanPham", b =>
                {
                    b.Property<int>("MaNhomSp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaNhomSP");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaNhomSp"));

                    b.Property<string>("TenNhomSp")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("TenNhomSP");

                    b.HasKey("MaNhomSp")
                        .HasName("PK__tbNhomSa__5A1AD2F985F055E7");

                    b.ToTable("tbNhomSanPham", (string)null);
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbPhanHoi", b =>
                {
                    b.Property<int>("MaPhanHoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaPhanHoi"));

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToTable("tbPhanHoi", (string)null);
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbQuanTriVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNguoiDung")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToTable("tbQuanTriVien", (string)null);
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbSanPham", b =>
                {
                    b.Property<int>("MaSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSanPham"));

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("GiaBan")
                        .HasColumnType("money");

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaNhomSp")
                        .HasColumnType("int")
                        .HasColumnName("MaNhomSP");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaSanPham")
                        .HasName("PK__tbSanPha__FAC7442DA6D9D8DC");

                    b.HasIndex("MaNhomSp");

                    b.ToTable("tbSanPham", (string)null);
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbTinTuc", b =>
                {
                    b.Property<int>("MaTinTuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTinTuc"));

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("NgayDang")
                        .HasColumnType("date");

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaTinTuc")
                        .HasName("PK__tbTinTuc__B53648C018B441C9");

                    b.ToTable("tbTinTuc", (string)null);
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbChiTietHoaDonBan", b =>
                {
                    b.HasOne("Web_CuaHangCafe.Models.TbHoaDonBan", "MaHoaDonNavigation")
                        .WithMany("TbChiTietHoaDonBans")
                        .HasForeignKey("MaHoaDon")
                        .IsRequired()
                        .HasConstraintName("FK__tbChiTiet__MaHoa__440B1D61");

                    b.HasOne("Web_CuaHangCafe.Models.TbSanPham", "MaSanPhamNavigation")
                        .WithMany("TbChiTietHoaDonBans")
                        .HasForeignKey("MaSanPham")
                        .IsRequired()
                        .HasConstraintName("FK__tbChiTiet__MaSan__44FF419A");

                    b.Navigation("MaHoaDonNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbHoaDonBan", b =>
                {
                    b.HasOne("Web_CuaHangCafe.Models.TbKhachHang", "Customer")
                        .WithMany("TbHoaDonBans")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("FK__tbHoaDonB__Custo__45F365D3");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbSanPham", b =>
                {
                    b.HasOne("Web_CuaHangCafe.Models.TbNhomSanPham", "MaNhomSpNavigation")
                        .WithMany("TbSanPhams")
                        .HasForeignKey("MaNhomSp")
                        .IsRequired()
                        .HasConstraintName("FK__tbSanPham__MaNho__46E78A0C");

                    b.Navigation("MaNhomSpNavigation");
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbHoaDonBan", b =>
                {
                    b.Navigation("TbChiTietHoaDonBans");
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbKhachHang", b =>
                {
                    b.Navigation("TbHoaDonBans");
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbNhomSanPham", b =>
                {
                    b.Navigation("TbSanPhams");
                });

            modelBuilder.Entity("Web_CuaHangCafe.Models.TbSanPham", b =>
                {
                    b.Navigation("TbChiTietHoaDonBans");
                });
#pragma warning restore 612, 618
        }
    }
}
