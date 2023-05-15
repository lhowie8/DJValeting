using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DJValeting.Migrations
{
    /// <inheritdoc />
    public partial class _00000000000001_CreateBookingsSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flexibilities",
                columns: table => new
                {
                    FlexibilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flexibilities", x => x.FlexibilityId);
                });

            migrationBuilder.CreateTable(
                name: "VehicleSizes",
                columns: table => new
                {
                    VehicleSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleSizes", x => x.VehicleSizeId);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlexibilityId = table.Column<int>(type: "int", nullable: false),
                    VehicleSizeId = table.Column<int>(type: "int", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Flexibilities_FlexibilityId",
                        column: x => x.FlexibilityId,
                        principalTable: "Flexibilities",
                        principalColumn: "FlexibilityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_VehicleSizes_VehicleSizeId",
                        column: x => x.VehicleSizeId,
                        principalTable: "VehicleSizes",
                        principalColumn: "VehicleSizeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Flexibilities",
                columns: new[] { "FlexibilityId", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "+/- 1 Day" },
                    { 2, 2, "+/- 2 Days" },
                    { 3, 3, "+/- 3 Days" }
                });

            migrationBuilder.InsertData(
                table: "VehicleSizes",
                columns: new[] { "VehicleSizeId", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Small" },
                    { 2, 2, "Medium" },
                    { 3, 3, "Large" },
                    { 4, 4, "Van" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FlexibilityId",
                table: "Bookings",
                column: "FlexibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_VehicleSizeId",
                table: "Bookings",
                column: "VehicleSizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Flexibilities");

            migrationBuilder.DropTable(
                name: "VehicleSizes");
        }
    }
}
