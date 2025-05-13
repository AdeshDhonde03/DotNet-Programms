using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace poultry_management_system.web.Migrations
{
    /// <inheritdoc />
    public partial class Initilizemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DailyEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Opening_Birds = table.Column<int>(type: "int", nullable: false),
                    Mortallity = table.Column<int>(type: "int", nullable: false),
                    Feed_Consume = table.Column<int>(type: "int", nullable: false),
                    Avg_Weight = table.Column<int>(type: "int", nullable: false),
                    Daily_Eggs_Production = table.Column<int>(type: "int", nullable: false),
                    Health_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyEntry", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DailyEntry");
        }
    }
}
