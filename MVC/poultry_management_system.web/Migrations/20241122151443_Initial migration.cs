using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace poultry_management_system.web.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Closing_Birds",
                table: "DailyEntry",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Closing_Birds",
                table: "DailyEntry");
        }
    }
}
