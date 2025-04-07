using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtExhibitionSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 4, 4, 10, 40, 21, 659, DateTimeKind.Local).AddTicks(3398));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artworks",
                keyColumn: "ArtworkId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2025, 4, 4, 10, 39, 12, 227, DateTimeKind.Local).AddTicks(3297));
        }
    }
}
