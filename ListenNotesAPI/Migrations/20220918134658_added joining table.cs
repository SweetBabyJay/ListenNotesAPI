using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListenNotesAPI.Migrations
{
    public partial class addedjoiningtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Podcast_PodcastModelId",
                table: "Genre");

            migrationBuilder.DropIndex(
                name: "IX_Genre_PodcastModelId",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "PodcastModelId",
                table: "Genre");

            migrationBuilder.CreateTable(
                name: "GenreModelPodcastModel",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "INTEGER", nullable: false),
                    PodcastsId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreModelPodcastModel", x => new { x.GenresId, x.PodcastsId });
                    table.ForeignKey(
                        name: "FK_GenreModelPodcastModel_Genre_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreModelPodcastModel_Podcast_PodcastsId",
                        column: x => x.PodcastsId,
                        principalTable: "Podcast",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GenreModelPodcastModel_PodcastsId",
                table: "GenreModelPodcastModel",
                column: "PodcastsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreModelPodcastModel");

            migrationBuilder.AddColumn<string>(
                name: "PodcastModelId",
                table: "Genre",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genre_PodcastModelId",
                table: "Genre",
                column: "PodcastModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Podcast_PodcastModelId",
                table: "Genre",
                column: "PodcastModelId",
                principalTable: "Podcast",
                principalColumn: "Id");
        }
    }
}
