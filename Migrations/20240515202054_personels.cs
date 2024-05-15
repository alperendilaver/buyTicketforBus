using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace buyticketforbus.Migrations
{
    /// <inheritdoc />
    public partial class personels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drivers_tours_TourId",
                table: "drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_hosts_tours_tourId",
                table: "hosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hosts",
                table: "hosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_drivers",
                table: "drivers");

            migrationBuilder.RenameTable(
                name: "hosts",
                newName: "HostofBus");

            migrationBuilder.RenameTable(
                name: "drivers",
                newName: "Driver");

            migrationBuilder.RenameIndex(
                name: "IX_hosts_tourId",
                table: "HostofBus",
                newName: "IX_HostofBus_tourId");

            migrationBuilder.RenameIndex(
                name: "IX_drivers_TourId",
                table: "Driver",
                newName: "IX_Driver_TourId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HostofBus",
                table: "HostofBus",
                column: "HostsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                table: "Driver",
                column: "DriverId");

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Role = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Gender = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SurName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GovernmentId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.PersonelId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_tours_TourId",
                table: "Driver",
                column: "TourId",
                principalTable: "tours",
                principalColumn: "tourId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HostofBus_tours_tourId",
                table: "HostofBus",
                column: "tourId",
                principalTable: "tours",
                principalColumn: "tourId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_tours_TourId",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_HostofBus_tours_tourId",
                table: "HostofBus");

            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HostofBus",
                table: "HostofBus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                table: "Driver");

            migrationBuilder.RenameTable(
                name: "HostofBus",
                newName: "hosts");

            migrationBuilder.RenameTable(
                name: "Driver",
                newName: "drivers");

            migrationBuilder.RenameIndex(
                name: "IX_HostofBus_tourId",
                table: "hosts",
                newName: "IX_hosts_tourId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_TourId",
                table: "drivers",
                newName: "IX_drivers_TourId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hosts",
                table: "hosts",
                column: "HostsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_drivers",
                table: "drivers",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_drivers_tours_TourId",
                table: "drivers",
                column: "TourId",
                principalTable: "tours",
                principalColumn: "tourId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_hosts_tours_tourId",
                table: "hosts",
                column: "tourId",
                principalTable: "tours",
                principalColumn: "tourId");
        }
    }
}
