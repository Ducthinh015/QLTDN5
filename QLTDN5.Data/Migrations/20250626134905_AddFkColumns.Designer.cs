﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLTDN5.Data;

#nullable disable

namespace QLTDN5.Data.Migrations
{
    [DbContext(typeof(QLTDN5Context))]
    [Migration("20250626134905_AddFkColumns")]
    partial class AddFkColumns
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLTDN5.Entities.BangGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MaBac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaGia")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MucDen")
                        .HasColumnType("int");

                    b.Property<string>("MucDien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MucTu")
                        .HasColumnType("int");

                    b.Property<string>("TenBac")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BangGia");
                });

            modelBuilder.Entity("QLTDN5.Entities.ChiSoDien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChiSoCu")
                        .HasColumnType("int");

                    b.Property<int>("ChiSoMoi")
                        .HasColumnType("int");

                    b.Property<int>("CongToDienId")
                        .HasColumnType("int");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayGhi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThangNam")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CongToDienId");

                    b.HasIndex("KhachHangId");

                    b.ToTable("ChiSoDien");
                });

            modelBuilder.Entity("QLTDN5.Entities.CongToDien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BangGiaId")
                        .HasColumnType("int");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<string>("MaCongTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoSerial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BangGiaId");

                    b.HasIndex("KhachHangId");

                    b.ToTable("CongToDien");
                });

            modelBuilder.Entity("QLTDN5.Entities.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChiSoDienId")
                        .HasColumnType("int");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("SoTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ChiSoDienId");

                    b.HasIndex("KhachHangId");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("QLTDN5.Entities.KhachHang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CCCD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<string>("MaKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaSoThue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("QLTDN5.Entities.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DienThoai")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaNV")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("VaiTro")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("QLTDN5.Entities.TramDien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaTram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViTri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TramDien");
                });

            modelBuilder.Entity("QLTDN5.Entities.ChiSoDien", b =>
                {
                    b.HasOne("QLTDN5.Entities.CongToDien", "CongToDien")
                        .WithMany("ChiSoDiens")
                        .HasForeignKey("CongToDienId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QLTDN5.Entities.KhachHang", "KhachHang")
                        .WithMany("ChiSoDiens")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CongToDien");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("QLTDN5.Entities.CongToDien", b =>
                {
                    b.HasOne("QLTDN5.Entities.BangGia", "BangGia")
                        .WithMany()
                        .HasForeignKey("BangGiaId");

                    b.HasOne("QLTDN5.Entities.KhachHang", "KhachHang")
                        .WithMany("CongToDiens")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BangGia");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("QLTDN5.Entities.HoaDon", b =>
                {
                    b.HasOne("QLTDN5.Entities.ChiSoDien", "ChiSoDien")
                        .WithMany("HoaDons")
                        .HasForeignKey("ChiSoDienId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QLTDN5.Entities.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("KhachHangId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ChiSoDien");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("QLTDN5.Entities.ChiSoDien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("QLTDN5.Entities.CongToDien", b =>
                {
                    b.Navigation("ChiSoDiens");
                });

            modelBuilder.Entity("QLTDN5.Entities.KhachHang", b =>
                {
                    b.Navigation("ChiSoDiens");

                    b.Navigation("CongToDiens");

                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
