using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaijaEvent.Persistance.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NEvents",
                columns: table => new
                {
                    EventId = table.Column<Guid>(nullable: false),
                    Eventid = table.Column<Guid>(nullable: false),
                    EventName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NEvents", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NEvents");
        }
    }
}
