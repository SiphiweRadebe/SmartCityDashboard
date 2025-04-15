using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCityDashboard.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrafficEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoadwayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectionOfTravel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanesAffected = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanesStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimaryLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondaryLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstArticleCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventSubType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    PlannedEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Reported = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafficEvents", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrafficEvents");
        }
    }
}
