using Microsoft.EntityFrameworkCore.Migrations;

namespace Kokos_DataAccess.Migrations
{
    public partial class PushOrderHeaderEditToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "OrderHeader",
                newName: "Region");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Region",
                table: "OrderHeader",
                newName: "State");
        }
    }
}
