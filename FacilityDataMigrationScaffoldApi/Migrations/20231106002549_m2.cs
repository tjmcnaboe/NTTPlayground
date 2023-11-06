using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FacilityDataMigrationScaffoldApi.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InternalIdentifier",
                table: "Facilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "11111111x");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InternalIdentifier",
                table: "Facilities");
        }
    }
}
