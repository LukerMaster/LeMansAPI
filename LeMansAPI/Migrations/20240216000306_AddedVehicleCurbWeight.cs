using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeMansAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedVehicleCurbWeight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CurbWeightKg",
                table: "Cars",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurbWeightKg",
                table: "Cars");
        }
    }
}
