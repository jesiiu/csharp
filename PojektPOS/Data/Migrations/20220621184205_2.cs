using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PojektPOS.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Documents_DocumentsId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_DocumentsId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DocumentsId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "DocumentsId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_DocumentsId",
                table: "Products",
                column: "DocumentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Documents_DocumentsId",
                table: "Products",
                column: "DocumentsId",
                principalTable: "Documents",
                principalColumn: "Id");
        }
    }
}
