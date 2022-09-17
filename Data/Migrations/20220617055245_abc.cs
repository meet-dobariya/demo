using Microsoft.EntityFrameworkCore.Migrations;

namespace core_passport5.Data.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Applyingfor",
                table: "details",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Applyingfor",
                table: "details");
        }
    }
}
