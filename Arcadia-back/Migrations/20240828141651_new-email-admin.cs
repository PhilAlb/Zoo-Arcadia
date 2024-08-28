using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class newemailadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "249c9800-7fb7-489b-b127-6dd4aa819a26" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "249c9800-7fb7-489b-b127-6dd4aa819a26");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c4702ab9-c283-4d2b-85e4-c23da10dc525", 0, "58d6aa14-19f5-47cc-8eb6-6ee6e432c024", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEDyOVoH2fXb3xZY7YBGvxskeUpN81c998Qm0x73ha0W31U5602trT+KIPxdT44Xv4Q==", null, true, "4cfeb8ce-6798-4888-a972-505edbca952e", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "c4702ab9-c283-4d2b-85e4-c23da10dc525" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "c4702ab9-c283-4d2b-85e4-c23da10dc525" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4702ab9-c283-4d2b-85e4-c23da10dc525");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "249c9800-7fb7-489b-b127-6dd4aa819a26", 0, "aeed7fbc-2f74-4840-983d-26c98784ea44", "admin@mail.com", true, false, null, "Admin", "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEA0RxmbmRmsX8+GczF1ayPkITio3NL7FLCMPiTyAEjb4/2y1fux9xZ84Kmk978bwFg==", null, true, "48540b5e-e67f-499c-8ff2-1c7c1337add5", "Test", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "249c9800-7fb7-489b-b127-6dd4aa819a26" });
        }
    }
}
