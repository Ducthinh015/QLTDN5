using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLTDN5.Data.Migrations
{
    public partial class AddFkColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1) Thêm cột ChiSoDienId vào HoaDon
            migrationBuilder.AddColumn<int>(
                name: "ChiSoDienId",
                table: "HoaDon",
                type: "int",
                nullable: true);

            // 2) Tạo FK HoaDon → ChiSoDien
            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ChiSoDienId",
                table: "HoaDon",
                column: "ChiSoDienId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_ChiSoDiens_ChiSoDienId",
                table: "HoaDon",
                column: "ChiSoDienId",
                principalTable: "ChiSoDien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            // 3) Nếu bảng CongToDien còn thiếu KhachHangId, thêm tương tự:
            migrationBuilder.AddColumn<int>(
                name: "KhachHangId",
                table: "CongToDien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CongToDien_KhachHangId",
                table: "CongToDien",
                column: "KhachHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_CongToDien_KhachHangs_KhachHangId",
                table: "CongToDien",
                column: "KhachHangId",
                principalTable: "KhachHang",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // rollback theo thứ tự ngược lại
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_ChiSoDiens_ChiSoDienId",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_ChiSoDienId",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "ChiSoDienId",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_CongToDien_KhachHangs_KhachHangId",
                table: "CongToDien");

            migrationBuilder.DropIndex(
                name: "IX_CongToDien_KhachHangId",
                table: "CongToDien");

            migrationBuilder.DropColumn(
                name: "KhachHangId",
                table: "CongToDien");
        }
    }
}