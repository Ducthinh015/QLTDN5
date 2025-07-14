using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLTDN5.Data.Migrations
{
    /// <inheritdoc />
    public partial class SyncSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiSoDiens_CongToDiens_CongToDienId",
                table: "ChiSoDiens");

            migrationBuilder.DropForeignKey(
                name: "FK_CongToDiens_KhachHangs_KhachHangId",
                table: "CongToDiens");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TramDiens",
                table: "TramDiens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CongToDiens",
                table: "CongToDiens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiSoDiens",
                table: "ChiSoDiens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BangGias",
                table: "BangGias");

            migrationBuilder.RenameTable(
                name: "TramDiens",
                newName: "TramDien");

            migrationBuilder.RenameTable(
                name: "NhanViens",
                newName: "NhanVien");

            migrationBuilder.RenameTable(
                name: "KhachHangs",
                newName: "KhachHang");

            migrationBuilder.RenameTable(
                name: "HoaDons",
                newName: "HoaDon");

            migrationBuilder.RenameTable(
                name: "CongToDiens",
                newName: "CongToDien");

            migrationBuilder.RenameTable(
                name: "ChiSoDiens",
                newName: "ChiSoDien");

            migrationBuilder.RenameTable(
                name: "BangGias",
                newName: "BangGia");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDons_KhachHangId",
                table: "HoaDon",
                newName: "IX_HoaDon_KhachHangId");

            migrationBuilder.RenameIndex(
                name: "IX_CongToDiens_KhachHangId",
                table: "CongToDien",
                newName: "IX_CongToDien_KhachHangId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiSoDiens_CongToDienId",
                table: "ChiSoDien",
                newName: "IX_ChiSoDien_CongToDienId");

            migrationBuilder.AddColumn<int>(
                name: "ChiSoDienId",
                table: "HoaDon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BangGiaId",
                table: "CongToDien",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KhachHangId",
                table: "ChiSoDien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MucDen",
                table: "BangGia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MucTu",
                table: "BangGia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TramDien",
                table: "TramDien",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CongToDien",
                table: "CongToDien",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiSoDien",
                table: "ChiSoDien",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BangGia",
                table: "BangGia",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ChiSoDienId",
                table: "HoaDon",
                column: "ChiSoDienId");

            migrationBuilder.CreateIndex(
                name: "IX_CongToDien_BangGiaId",
                table: "CongToDien",
                column: "BangGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiSoDien_KhachHangId",
                table: "ChiSoDien",
                column: "KhachHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiSoDien_CongToDien_CongToDienId",
                table: "ChiSoDien",
                column: "CongToDienId",
                principalTable: "CongToDien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiSoDien_KhachHang_KhachHangId",
                table: "ChiSoDien",
                column: "KhachHangId",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CongToDien_BangGia_BangGiaId",
                table: "CongToDien",
                column: "BangGiaId",
                principalTable: "BangGia",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CongToDien_KhachHang_KhachHangId",
                table: "CongToDien",
                column: "KhachHangId",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_ChiSoDien_ChiSoDienId",
                table: "HoaDon",
                column: "ChiSoDienId",
                principalTable: "ChiSoDien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHang_KhachHangId",
                table: "HoaDon",
                column: "KhachHangId",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiSoDien_CongToDien_CongToDienId",
                table: "ChiSoDien");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiSoDien_KhachHang_KhachHangId",
                table: "ChiSoDien");

            migrationBuilder.DropForeignKey(
                name: "FK_CongToDien_BangGia_BangGiaId",
                table: "CongToDien");

            migrationBuilder.DropForeignKey(
                name: "FK_CongToDien_KhachHang_KhachHangId",
                table: "CongToDien");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_ChiSoDien_ChiSoDienId",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHang_KhachHangId",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TramDien",
                table: "TramDien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NhanVien",
                table: "NhanVien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KhachHang",
                table: "KhachHang");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDon",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_ChiSoDienId",
                table: "HoaDon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CongToDien",
                table: "CongToDien");

            migrationBuilder.DropIndex(
                name: "IX_CongToDien_BangGiaId",
                table: "CongToDien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiSoDien",
                table: "ChiSoDien");

            migrationBuilder.DropIndex(
                name: "IX_ChiSoDien_KhachHangId",
                table: "ChiSoDien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BangGia",
                table: "BangGia");

            migrationBuilder.DropColumn(
                name: "ChiSoDienId",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "BangGiaId",
                table: "CongToDien");

            migrationBuilder.DropColumn(
                name: "KhachHangId",
                table: "ChiSoDien");

            migrationBuilder.DropColumn(
                name: "MucDen",
                table: "BangGia");

            migrationBuilder.DropColumn(
                name: "MucTu",
                table: "BangGia");

            migrationBuilder.RenameTable(
                name: "TramDien",
                newName: "TramDiens");

            migrationBuilder.RenameTable(
                name: "NhanVien",
                newName: "NhanViens");

            migrationBuilder.RenameTable(
                name: "KhachHang",
                newName: "KhachHangs");

            migrationBuilder.RenameTable(
                name: "HoaDon",
                newName: "HoaDons");

            migrationBuilder.RenameTable(
                name: "CongToDien",
                newName: "CongToDiens");

            migrationBuilder.RenameTable(
                name: "ChiSoDien",
                newName: "ChiSoDiens");

            migrationBuilder.RenameTable(
                name: "BangGia",
                newName: "BangGias");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_KhachHangId",
                table: "HoaDons",
                newName: "IX_HoaDons_KhachHangId");

            migrationBuilder.RenameIndex(
                name: "IX_CongToDien_KhachHangId",
                table: "CongToDiens",
                newName: "IX_CongToDiens_KhachHangId");

            migrationBuilder.RenameIndex(
                name: "IX_ChiSoDien_CongToDienId",
                table: "ChiSoDiens",
                newName: "IX_ChiSoDiens_CongToDienId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TramDiens",
                table: "TramDiens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NhanViens",
                table: "NhanViens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KhachHangs",
                table: "KhachHangs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDons",
                table: "HoaDons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CongToDiens",
                table: "CongToDiens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiSoDiens",
                table: "ChiSoDiens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BangGias",
                table: "BangGias",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiSoDiens_CongToDiens_CongToDienId",
                table: "ChiSoDiens",
                column: "CongToDienId",
                principalTable: "CongToDiens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CongToDiens_KhachHangs_KhachHangId",
                table: "CongToDiens",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDons_KhachHangs_KhachHangId",
                table: "HoaDons",
                column: "KhachHangId",
                principalTable: "KhachHangs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
