using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LangateWrapUpDbApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    idArtist = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    strArtist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistStripped = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistAlternate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strLabel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    intFormedYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    intBornYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    intDiedYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    strDisbanded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strGenre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strMood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strFacebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strTwitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyEN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyDE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyFR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyCN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyJP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyRU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyPT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographySE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyNL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyHU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyNO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strBiographyPL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intMembers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    strCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strCountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistThumb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistCutout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistClearart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistWideThumb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistFanart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistFanart2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistFanart3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistFanart4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strArtistBanner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strMusicBrainzID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strISNIcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strLastFMChart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    intCharted = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    strLocked = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.idArtist);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
