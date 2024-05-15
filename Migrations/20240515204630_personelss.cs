using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace buyticketforbus.Migrations
{
    /// <inheritdoc />
    public partial class personelss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "HostofBus");

            migrationBuilder.AddColumn<int>(
                name: "tourId",
                table: "personels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_personels_tourId",
                table: "personels",
                column: "tourId");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_tours_tourId",
                table: "personels",
                column: "tourId",
                principalTable: "tours",
                principalColumn: "tourId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_tours_tourId",
                table: "personels");

            migrationBuilder.DropIndex(
                name: "IX_personels_tourId",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "tourId",
                table: "personels");

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GovernmentId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SurName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Driver_tours_TourId",
                        column: x => x.TourId,
                        principalTable: "tours",
                        principalColumn: "tourId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HostofBus",
                columns: table => new
                {
                    HostsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tourId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GovernmentId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SurName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostofBus", x => x.HostsId);
                    table.ForeignKey(
                        name: "FK_HostofBus_tours_tourId",
                        column: x => x.tourId,
                        principalTable: "tours",
                        principalColumn: "tourId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_TourId",
                table: "Driver",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_HostofBus_tourId",
                table: "HostofBus",
                column: "tourId",
                unique: true);
        }
    }
}
