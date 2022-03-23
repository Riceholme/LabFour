using Microsoft.EntityFrameworkCore.Migrations;

namespace LabFour.API.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    InterestId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.InterestId);
                    table.ForeignKey(
                        name: "FK_Interests_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WebSites",
                columns: table => new
                {
                    WebSiteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    InterestId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebSites", x => x.WebSiteId);
                    table.ForeignKey(
                        name: "FK_WebSites_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "InterestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Erik", "0703232323" },
                    { 2, "Erik", "0734343434" },
                    { 3, "Lucas", "0700654321" },
                    { 4, "Viktor", "0707333444" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestId", "Description", "PersonId", "Title" },
                values: new object[,]
                {
                    { 1, "Multiplayer online battle arena", 1, "Defense Of The Ancients 2" },
                    { 2, "Action Adventure", 2, "God of War" },
                    { 3, "Open-World Action RPG", 3, "Elden Ring" },
                    { 4, "Multiplayer online battle arena", 4, "League of Legends" }
                });

            migrationBuilder.InsertData(
                table: "WebSites",
                columns: new[] { "WebSiteId", "Description", "InterestId", "Link" },
                values: new object[,]
                {
                    { 1, "Dota 2 Website", 1, "https://www.dota2.com/home" },
                    { 2, "Wikipedia link", 2, "https://en.wikipedia.org/wiki/God_of_War_(2018_video_game)" },
                    { 3, "Wikipedia link", 3, "https://en.wikipedia.org/wiki/Elden_Ring" },
                    { 4, "League of Legends Website", 4, "https://www.leagueoflegends.com/en-gb/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interests_PersonId",
                table: "Interests",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_WebSites_InterestId",
                table: "WebSites",
                column: "InterestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebSites");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
