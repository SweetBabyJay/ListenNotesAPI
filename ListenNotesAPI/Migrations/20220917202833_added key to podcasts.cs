using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListenNotesAPI.Migrations
{
    public partial class addedkeytopodcasts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ListenNotesURL",
                table: "Podcast",
                newName: "ListenNotes_URL");

            migrationBuilder.RenameColumn(
                name: "ITunesID",
                table: "Podcast",
                newName: "ITunes_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ListenNotes_URL",
                table: "Podcast",
                newName: "ListenNotesURL");

            migrationBuilder.RenameColumn(
                name: "ITunes_ID",
                table: "Podcast",
                newName: "ITunesID");
        }
    }
}
