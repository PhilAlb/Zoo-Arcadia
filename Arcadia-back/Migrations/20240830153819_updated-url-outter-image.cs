using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class updatedurloutterimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "e8583946-e01f-4f8e-92e7-0bf6082bb30a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8583946-e01f-4f8e-92e7-0bf6082bb30a");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Shere Khan");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "assets/images/animals/outter1.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "98e31e9c-89f0-4597-ab19-76f5bde8b5cd", 0, "4cd2a977-a99b-45a5-8f88-fc6e6a48592c", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAECtZ2bEcdHsizrHtxmvAsi1rX45OzM75ipk64rMYmnSNT/WzNxh3YRtjJVtoRqOeFA==", null, true, "213499e5-3c13-453f-937f-f422bbd3afe8", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "98e31e9c-89f0-4597-ab19-76f5bde8b5cd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "98e31e9c-89f0-4597-ab19-76f5bde8b5cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e31e9c-89f0-4597-ab19-76f5bde8b5cd");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Sherkan");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "assets/animals/outter1.jpg");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8583946-e01f-4f8e-92e7-0bf6082bb30a", 0, "1cf9e6ce-8e87-45d5-8075-6361482817f6", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEBVXWnoWgi55dRr4Re5gtYUDMnsI/trf4wRS2pYkBf22Ye7Pt6CmYfQwaX1VWsv3gw==", null, true, "73f446ce-e36e-489c-b55d-0cd41997bfdf", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "e8583946-e01f-4f8e-92e7-0bf6082bb30a" });
        }
    }
}
