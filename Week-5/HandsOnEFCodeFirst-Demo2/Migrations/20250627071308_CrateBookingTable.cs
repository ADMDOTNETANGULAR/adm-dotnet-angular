using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsOnEFCodeFirst_Demo2.Migrations
{
    /// <inheritdoc />
    public partial class CrateBookingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookId = table.Column<string>(type: "char(5)", maxLength: 5, nullable: false),
                    BookingDate = table.Column<DateTime>(type: "Date", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Booking_tbl_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "tbl_movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade); // Foreign key constraint to the Movie table
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_MovieId",
                table: "Booking",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");
        }
    }
}
