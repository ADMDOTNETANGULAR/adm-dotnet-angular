using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsOnAPIUsingEFCore.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FightCode",
                table: "Flights",
                newName: "FlightCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlightCode",
                table: "Flights",
                newName: "FightCode");
        }
    }
}
