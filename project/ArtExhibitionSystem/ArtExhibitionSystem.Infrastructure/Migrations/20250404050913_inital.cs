using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArtExhibitionSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistBirthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArtistPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtistID);
                });

            migrationBuilder.CreateTable(
                name: "Artworks",
                columns: table => new
                {
                    ArtworkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    ArtistsArtistID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artworks", x => x.ArtworkId);
                    table.ForeignKey(
                        name: "FK_Artworks_Artists_ArtistsArtistID",
                        column: x => x.ArtistsArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID");
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    GalleryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    ArtistsArtistID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.GalleryId);
                    table.ForeignKey(
                        name: "FK_Galleries_Artists_ArtistsArtistID",
                        column: x => x.ArtistsArtistID,
                        principalTable: "Artists",
                        principalColumn: "ArtistID");
                });

            migrationBuilder.CreateTable(
                name: "FavoriteArtWork",
                columns: table => new
                {
                    FavouriteArtWorkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ArtworkId = table.Column<int>(type: "int", nullable: false),
                    ArtworksArtworkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteArtWork", x => x.FavouriteArtWorkId);
                    table.ForeignKey(
                        name: "FK_FavoriteArtWork_Artworks_ArtworksArtworkId",
                        column: x => x.ArtworksArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "ArtworkId");
                });

            migrationBuilder.CreateTable(
                name: "ArtworkGallery",
                columns: table => new
                {
                    ArtworkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtworksArtworkId = table.Column<int>(type: "int", nullable: true),
                    GalleryId = table.Column<int>(type: "int", nullable: false),
                    GalleriesGalleryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtworkGallery", x => x.ArtworkId);
                    table.ForeignKey(
                        name: "FK_ArtworkGallery_Artworks_ArtworksArtworkId",
                        column: x => x.ArtworksArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "ArtworkId");
                    table.ForeignKey(
                        name: "FK_ArtworkGallery_Galleries_GalleriesGalleryId",
                        column: x => x.GalleriesGalleryId,
                        principalTable: "Galleries",
                        principalColumn: "GalleryId");
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistID", "ArtistBirthdate", "ArtistName", "ArtistPhone" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sumit", "100" },
                    { 2, new DateTime(2001, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kapil", "95456188188" }
                });

            migrationBuilder.InsertData(
                table: "ArtworkGallery",
                columns: new[] { "ArtworkId", "ArtworksArtworkId", "GalleriesGalleryId", "GalleryId" },
                values: new object[] { 1, null, null, 1 });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "ArtworkId", "ArtistId", "ArtistsArtistID", "CreationDate", "Description", "ImageURL", "Title" },
                values: new object[] { 1, 1, null, new DateTime(2025, 4, 4, 10, 39, 12, 227, DateTimeKind.Local).AddTicks(3297), "horse Painting", "sdfqr", "Painting" });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "GalleryId", "ArtistId", "ArtistsArtistID", "Description", "Location", "Name" },
                values: new object[] { 1, 1, null, "A collection of modern artworks", "New York", "Modern Art Gallery" });

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkGallery_ArtworksArtworkId",
                table: "ArtworkGallery",
                column: "ArtworksArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtworkGallery_GalleriesGalleryId",
                table: "ArtworkGallery",
                column: "GalleriesGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_ArtistsArtistID",
                table: "Artworks",
                column: "ArtistsArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteArtWork_ArtworksArtworkId",
                table: "FavoriteArtWork",
                column: "ArtworksArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_ArtistsArtistID",
                table: "Galleries",
                column: "ArtistsArtistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtworkGallery");

            migrationBuilder.DropTable(
                name: "FavoriteArtWork");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Artworks");

            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
