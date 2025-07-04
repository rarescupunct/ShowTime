using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowTime.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Festivals_FestivalID",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "BandFestival");

            migrationBuilder.RenameColumn(
                name: "FestivalID",
                table: "Bookings",
                newName: "FestivalId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_FestivalID",
                table: "Bookings",
                newName: "IX_Bookings_FestivalId");

            migrationBuilder.CreateTable(
                name: "BandFestivals",
                columns: table => new
                {
                    FestivalID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BandID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandFestivals", x => new { x.BandID, x.FestivalID });
                    table.ForeignKey(
                        name: "FK_BandFestivals_Bands_BandID",
                        column: x => x.BandID,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BandFestivals_Festivals_FestivalID",
                        column: x => x.FestivalID,
                        principalTable: "Festivals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BandFestivals_FestivalID",
                table: "BandFestivals",
                column: "FestivalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Festivals_FestivalId",
                table: "Bookings",
                column: "FestivalId",
                principalTable: "Festivals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Festivals_FestivalId",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "BandFestivals");

            migrationBuilder.RenameColumn(
                name: "FestivalId",
                table: "Bookings",
                newName: "FestivalID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_FestivalId",
                table: "Bookings",
                newName: "IX_Bookings_FestivalID");

            migrationBuilder.CreateTable(
                name: "BandFestival",
                columns: table => new
                {
                    BandsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FestivalsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BandFestival", x => new { x.BandsId, x.FestivalsID });
                    table.ForeignKey(
                        name: "FK_BandFestival_Bands_BandsId",
                        column: x => x.BandsId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BandFestival_Festivals_FestivalsID",
                        column: x => x.FestivalsID,
                        principalTable: "Festivals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BandFestival_FestivalsID",
                table: "BandFestival",
                column: "FestivalsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Festivals_FestivalID",
                table: "Bookings",
                column: "FestivalID",
                principalTable: "Festivals",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
