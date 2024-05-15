using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace buyticketforbus.Migrations
{
    /// <inheritdoc />
    public partial class uniqueGovernment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GovernmentId",
                table: "personels",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "GovernmentId",
                table: "passengers",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_personels_GovernmentId",
                table: "personels",
                column: "GovernmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_passengers_GovernmentId",
                table: "passengers",
                column: "GovernmentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_personels_GovernmentId",
                table: "personels");

            migrationBuilder.DropIndex(
                name: "IX_passengers_GovernmentId",
                table: "passengers");

            migrationBuilder.AlterColumn<string>(
                name: "GovernmentId",
                table: "personels",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "GovernmentId",
                table: "passengers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
