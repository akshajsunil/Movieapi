using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Actor",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReleaseYear",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actor",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ReleaseYear",
                table: "Movie");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Movie",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Movie",
                type: "int",
                nullable: true);
        }
    }
}
