using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLTDN5.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BangGias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaBac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenBac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaGia = table.Column<int>(type: "int", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MucDien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangGias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangId = table.Column<int>(type: "int", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaSoThue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNV = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //  name: "TramDiens",
            //   columns: table => new
            //    {
            //      Id = table.Column<int>(type: "int", nullable: false)
            //         .Annotation("SqlServer:Identity", "1, 1"),
            //      MaTram = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
            //      TenTram = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
            //      DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
            //    CongSuat = table.Column<int>(type: "int", nullable: false),
            //      GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
            //    },
            //      constraints: table =>
            //    {
            //         table.PrimaryKey("PK_TramDiens", x => x.Id);
            //  });

            migrationBuilder.CreateTable(
                name: "CongToDiens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoSerial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaCongTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhachHangId = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CongToDiens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CongToDiens_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangId = table.Column<int>(type: "int", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiSoDiens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CongToDienId = table.Column<int>(type: "int", nullable: false),
                    NgayGhi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChiSoCu = table.Column<int>(type: "int", nullable: false),
                    ChiSoMoi = table.Column<int>(type: "int", nullable: false),
                    ThangNam = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiSoDiens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiSoDiens_CongToDiens_CongToDienId",
                        column: x => x.CongToDienId,
                        principalTable: "CongToDiens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiSoDiens_CongToDienId",
                table: "ChiSoDiens",
                column: "CongToDienId");

            migrationBuilder.CreateIndex(
                name: "IX_CongToDiens_KhachHangId",
                table: "CongToDiens",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangGias");

            migrationBuilder.DropTable(
                name: "ChiSoDiens");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "NhanViens");

            //  migrationBuilder.DropTable(
            //    name: "TramDiens");

            migrationBuilder.DropTable(
                name: "CongToDiens");

            migrationBuilder.DropTable(
                name: "KhachHangs");
        }
    }
}