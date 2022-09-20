using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListenNotesAPI.Migrations
{
    public partial class removedpodcastfromgenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "GenreModelId",
                table: "Podcast");

            migrationBuilder.DropColumn(
                name: "PodcastModelId1",
                table: "Genre");

            migrationBuilder.AddColumn<string>(
                name: "PodcastModelId",
                table: "Genre",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_PodcastModelId",
                table: "Genre",
                column: "PodcastModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Podcast_PodcastModelId",
                table: "Genre",
                column: "PodcastModelId",
                principalTable: "Podcast",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
