using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacilityDataMigrationScaffoldApi.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "77, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapacityCounters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Open = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Close = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacityCounters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CapacityCounters_Facilities_FacilityId",
                        column: x => x.FacilityId,
                        principalTable: "Facilities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CounterDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CountedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacityCounterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounterDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CounterDetails_CapacityCounters_CapacityCounterId",
                        column: x => x.CapacityCounterId,
                        principalTable: "CapacityCounters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CapacityCounters_FacilityId",
                table: "CapacityCounters",
                column: "FacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_CounterDetails_CapacityCounterId",
                table: "CounterDetails",
                column: "CapacityCounterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CounterDetails");

            migrationBuilder.DropTable(
                name: "CapacityCounters");

            migrationBuilder.DropTable(
                name: "Facilities");
        }
    }
}
