using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HandsOnEFCodeFirst_Demo2.Migrations
{
    /// <inheritdoc />
    public partial class SeedMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_movies",
                columns: new[] { "MovieId", "Director", "Genre", "Rating", "ReleaseDate", "title" },
                values: new object[,]
                {
                    { 1, "Christopher Nolan", "Sci-Fi", 8.8m, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception" },
                    { 2, "Francis Ford Coppola", "Crime", 9.2m, new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather" },
                    { 3, "Quentin Tarantino", "Crime", 8.9m, new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { 4, "Frank Darabont", "Drama", 9.3m, new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shawshank Redemption" },
                    { 5, "Christopher Nolan", "Sci-Fi", 8.6m, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar" },
                    { 6, "Bong Joon-ho", "Thriller", 8.6m, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parasite" },
                    { 7, "Ridley Scott", "Action", 8.5m, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiator" },
                    { 8, "James Cameron", "Romance", 7.8m, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic" },
                    { 9, "Lana Wachowski", "Sci-Fi", 8.7m, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix" },
                    { 10, "Anthony Russo", "Superhero", 8.4m, new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avengers: Endgame" },
                    { 11, "Todd Phillips", "Drama", 8.5m, new DateTime(2019, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joker" },
                    { 12, "Robert Zemeckis", "Drama", 8.8m, new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump" },
                    { 13, "David Fincher", "Drama", 8.8m, new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fight Club" },
                    { 14, "Christopher Nolan", "Action", 9.0m, new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dark Knight" },
                    { 15, "Hayao Miyazaki", "Animation", 8.6m, new DateTime(2001, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spirited Away" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "tbl_movies",
                keyColumn: "MovieId",
                keyValue: 15);
        }
    }
}
