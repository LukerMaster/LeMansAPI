using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeMansAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedCarColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "RaceEntryResults",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RaceEntryResults_CarId",
                table: "RaceEntryResults",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_RaceEntryResults_Cars_CarId",
                table: "RaceEntryResults",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RaceEntryResults_Cars_CarId",
                table: "RaceEntryResults");

            migrationBuilder.DropIndex(
                name: "IX_RaceEntryResults_CarId",
                table: "RaceEntryResults");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "RaceEntryResults");
        }
    }
}
