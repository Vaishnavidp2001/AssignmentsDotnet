using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtExhibitionSystem.Identity.Migrations
{
    /// <inheritdoc />
    public partial class initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b16f58b9-1c10-4d28-9cc4-9dcdd3348931", "AQAAAAIAAYagAAAAEGgLN0SK4nKdbksiRrCtZT8ag8MZXe2deu5wqvlPXz/xWXg45K2UoNGJwUnxwTaZpQ==", "3fdede26-9b06-4724-806c-1f315ede4cd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fcf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aaf615dc-c053-4389-ba08-ff844dbcb9fa", "vaish@gamil.com", "vaish", "patil", "VAISH@GMAIL.COM", "vaish@gamil.com", "AQAAAAIAAYagAAAAEBwffJL7xKHXUbiTiGGhrSirUAz5xO1QW/qqj9n4Kyxxrr9nzJBte5taVN0DakxgTA==", "df9a8556-c524-40e1-9d88-20588d4077f4", "vaish@gamil.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "41776063 - 6086 - 1fcf - b923 - 2879a6680b9a", 0, "5a324f72-592f-4f41-9e8f-4d17408db1d0", "ApplicationUser", "patil@gamil.com", false, "rupa", "patil", false, null, "PATIL@GMAIL.COM", "patil@gamil.com", "AQAAAAIAAYagAAAAEIG1v89SNvKK0Z3wfZE9ABwrENCCysqYuLg3psr5nbS2CplUtZx4IsXIQP49e2+XsQ==", null, false, "e756bad2-045e-48af-a5e3-18ff99aad468", false, "patil@gamil.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776063 - 6086 - 1fcf - b923 - 2879a6680b9a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fbf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1438ab4-d42c-45af-b9e6-74eb38c7bd3b", "AQAAAAIAAYagAAAAEMAGpNlYuyNxxKu3FG0Jop807hNR5dKOc8qNxCAxaiaHJHA4IVpB/EjyZHlJQ6Ed0g==", "61c5854c-3330-49b6-a94c-1f08d5116f36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41776062 - 6086 - 1fcf - b923 - 2879a6680b9a",
                columns: new[] { "ConcurrencyStamp", "Email", "FirstName", "LastName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "77ba1c64-9cdb-450f-a307-babe63e9931e", "sunny@gmail.com", "sunny", "Jogdand", "SUNNY@GMAIL.COM", "sunny@gmail.com", "AQAAAAIAAYagAAAAEN306Xzmd9MWPv1iR+/cD0OYN/YzvYvrHjs7xJxKQT/CupLVu5cXtqQ2/+m5Y1uu+A==", "62f72a27-dc5d-445f-bcfc-9cf7aaffa044", "sunny@gmail.com" });
        }
    }
}
