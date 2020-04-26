using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlaBCar.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomBooker = table.Column<string>(nullable: true),
                    TelephoneBooker = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trajets",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomChauffeur = table.Column<string>(nullable: true),
                    TelephoneChauffeur = table.Column<string>(nullable: true),
                    AgeChauffeur = table.Column<long>(nullable: false),
                    LieuDepart = table.Column<string>(nullable: true),
                    LieuArrive = table.Column<string>(nullable: true),
                    DateDepart = table.Column<DateTime>(nullable: false),
                    DureeTrajet = table.Column<long>(nullable: false),
                    NbrePlaceDispo = table.Column<long>(nullable: false),
                    NbreReservation = table.Column<long>(nullable: false),
                    Bagage = table.Column<bool>(nullable: false),
                    Fumeur = table.Column<bool>(nullable: false),
                    Handicape = table.Column<bool>(nullable: false),
                    Animaux = table.Column<bool>(nullable: false),
                    ReservationId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trajets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trajets_Reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trajets_ReservationId",
                table: "Trajets",
                column: "ReservationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trajets");

            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}
