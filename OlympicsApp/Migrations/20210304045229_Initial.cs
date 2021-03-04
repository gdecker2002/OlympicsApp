using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicsApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.SportID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SportID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Games_GameID",
                        column: x => x.GameID,
                        principalTable: "Games",
                        principalColumn: "GameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Sports_SportID",
                        column: x => x.SportID,
                        principalTable: "Sports",
                        principalColumn: "SportID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "winter olympics", "Winter Olympics" },
                    { "summer olympics", "Summer Olympics" },
                    { "paralympics", "Paralympics" },
                    { "youth olympic games", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "Sports",
                columns: new[] { "SportID", "Name" },
                values: new object[,]
                {
                    { "curling", "Curling/Indoor" },
                    { "bobsleigh", "Bobsleigh/Outdoor" },
                    { "diving", "Diving/Indoor" },
                    { "road cycling", "Road Cycling/Outdoor" },
                    { "archery", "Archery/Indoor" },
                    { "canoe sprint", "Canoe Sprint/Outdoor" },
                    { "break dancing", "Break Dancing/Indoor" },
                    { "skateboarding", "Skateboarding/Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "FlagImage", "GameID", "Name", "SportID" },
                values: new object[,]
                {
                    { "CA", "CA.png", "winter olympics", "Canada", "curling" },
                    { "FI", "FI.png", "youth olympic games", "Finland", "skateboarding" },
                    { "RU", "RU.png", "youth olympic games", "Russia", "break dancing" },
                    { "CY", "CY.png", "youth olympic games", "Cyprus", "break dancing" },
                    { "FR", "FR.png", "youth olympic games", "France", "break dancing" },
                    { "ZI", "ZI.png", "paralympics", "Zimbabwe", "canoe sprint" },
                    { "PK", "PK.png", "paralympics", "Pakistan", "canoe sprint" },
                    { "AT", "AT.png", "paralympics", "Austria", "canoe sprint" },
                    { "UA", "UA.png", "paralympics", "Ukraine", "archery" },
                    { "UY", "UY.png", "paralympics", "Uruguay", "archery" },
                    { "TH", "TH.png", "paralympics", "Thailand", "archery" },
                    { "US", "US.png", "summer olympics", "United States", "road cycling" },
                    { "NL", "NL.png", "summer olympics", "Netherlands", "road cycling" },
                    { "BR", "BR.png", "summer olympics", "Brazil", "road cycling" },
                    { "MX", "MX.png", "summer olympics", "Mexico", "diving" },
                    { "CN", "CN.png", "summer olympics", "China", "diving" },
                    { "GA", "GA.png", "summer olympics", "Germany", "diving" },
                    { "JP", "JP.png", "winter olympics", "Japan", "bobsleigh" },
                    { "IL", "IL.png", "winter olympics", "Italy", "bobsleigh" },
                    { "JA", "JA.png", "winter olympics", "Jamaica", "bobsleigh" },
                    { "GB", "GB.png", "winter olympics", "Great Britain", "curling" },
                    { "SW", "SW.png", "winter olympics", "Sweden", "curling" },
                    { "SK", "SK.png", "youth olympic games", "Slovakia", "skateboarding" },
                    { "PT", "PT.png", "youth olympic games", "Portugal", "skateboarding" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_GameID",
                table: "Countries",
                column: "GameID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_SportID",
                table: "Countries",
                column: "SportID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
