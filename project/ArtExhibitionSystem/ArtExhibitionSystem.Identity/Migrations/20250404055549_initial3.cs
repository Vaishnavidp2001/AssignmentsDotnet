using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtExhibitionSystem.Identity.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c1438ab4-d42c-45af-b9e6-74eb38c7bd3b", "AQAAAAIAAYagAAAAEMAGpNlYuyNxxKu3FG0Jop807hNR5dKOc8qNxCAxaiaHJHA4IVpB/EjyZHlJQ6Ed0g==", "61c5854c-3330-49b6-a94c-1f08d5116f36", "admin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fcf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "77ba1c64-9cdb-450f-a307-babe63e9931e", "AQAAAAIAAYagAAAAEN306Xzmd9MWPv1iR+/cD0OYN/YzvYvrHjs7xJxKQT/CupLVu5cXtqQ2/+m5Y1uu+A==", "62f72a27-dc5d-445f-bcfc-9cf7aaffa044", "sunny@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d4d73ce5-af1d-4678-921f-46ca36be73bd", "AQAAAAIAAYagAAAAEB+u6mfX6JXc9miIOnFexiEzxuciw6bkSBCcaU4dYt/r69E7E/YEyx/ybUBWkpw3cQ==", "714437f4-0c87-4fd1-b432-a38e4cf35d2c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fcf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d69f33bb-4472-4efa-9cbf-041332e761a3", "AQAAAAIAAYagAAAAEGfQ7j5LNTyYWW8ykpfG+tbNsZ6pSxqlxtvXwaHp79jP0jt+ntJDIUelPsGW4mJVxQ==", "20b7b1c1-833d-4725-a6b9-c5a338011bf8", null });
        }
    }
}
