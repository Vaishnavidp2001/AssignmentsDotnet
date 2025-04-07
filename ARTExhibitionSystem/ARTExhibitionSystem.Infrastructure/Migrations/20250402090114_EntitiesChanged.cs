using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ARTExhibitionSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Artists");
        }
    }
}
