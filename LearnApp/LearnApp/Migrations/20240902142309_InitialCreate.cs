using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    carId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    plate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datePlate = table.Column<DateOnly>(type: "date", nullable: false),
                    carOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    carName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mark = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.carId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
