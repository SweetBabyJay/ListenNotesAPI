using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListenNotesAPI.Migrations
{
    public partial class messingaround : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreModelPodcastModel");

            migrationBuilder.AddColumn<int>(
                name: "GenreID",
                table: "Podcast",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreModelId",
                table: "Podcast",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PodcastModelId1",
                table: "Genre",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Podcast_GenreModelId",
                table: "Podcast",
                column: "GenreModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_PodcastModelId1",
                table: "Genre",
                column: "PodcastModelId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Podcast_PodcastModelId1",
                table: "Genre",
                column: "PodcastModelId1",
                principalTable: "Podcast",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Podcast_Genre_GenreModelId",
                table: "Podcast",
                column: "GenreModelId",
                principalTable: "Genre",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Podcast_PodcastModelId1",
                table: "Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Podcast_Genre_GenreModelId",
                table: "Podcast");

            migrationBuilder.DropIndex(
                name: "IX_Podcast_GenreModelId",
                table: "Podcast");

            migrationBuilder.DropIndex(
                name: "IX_Genre_PodcastModelId1",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "GenreID",
                table: "Podcast");

            migrationBuilder.DropColumn(
                name: "GenreModelId",
                table: "Podcast");

            migrationBuilder.DropColumn(
                name: "PodcastModelId1",
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
    }
}
