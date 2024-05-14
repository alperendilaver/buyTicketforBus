using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace buyticketforbus.Migrations
{
    /// <inheritdoc />
    public partial class drivershosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drivers_tours_tourId",
                table: "drivers");

            migrationBuilder.RenameColumn(
                name: "tourId",
                table: "drivers",
                newName: "TourId");

            migrationBuilder.RenameIndex(
                name: "IX_drivers_tourId",
                table: "drivers",
                newName: "IX_drivers_TourId");

            migrationBuilder.AlterColumn<int>(
                name: "TourId",
                table: "drivers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_drivers_tours_TourId",
                table: "drivers",
                column: "TourId",
                principalTable: "tours",
                principalColumn: "tourId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drivers_tours_TourId",
                table: "drivers");

            migrationBuilder.RenameColumn(
                name: "TourId",
                table: "drivers",
                newName: "tourId");

            migrationBuilder.RenameIndex(
                name: "IX_drivers_TourId",
                table: "drivers",
                newName: "IX_drivers_tourId");

            migrationBuilder.AlterColumn<int>(
                name: "tourId",
                table: "drivers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_drivers_tours_tourId",
                table: "drivers",
                column: "tourId",
                principalTable: "tours",
                principalColumn: "tourId");
        }
    }
}
