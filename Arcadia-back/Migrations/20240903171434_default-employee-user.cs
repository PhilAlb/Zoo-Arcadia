using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class defaultemployeeuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "40ce474f-16ec-45c9-8b5e-aed04d5db56a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40ce474f-16ec-45c9-8b5e-aed04d5db56a");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5e162906-6d18-4189-9ad8-d53b33497507", 0, "55688f55-6b93-45eb-bd31-64b05d2aa34a", "employee@zoo-arcadia.com", true, false, null, "Employé", "EMPLOYEE@ZOO-ARCADIA.COM", "EMPLOYEE@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAENFg487DxKiLrZ0cSGhXlHUj7hS5KYuusSZ2TroVTaETF05rMExKcMUFgVM2UYhXJw==", null, true, "f53ebd7d-8c8c-45e5-bd46-6e8fc8f7693d", "Test", false, "employee@zoo-arcadia.com" },
                    { "fac71d72-5e8a-4404-9851-a1658c816082", 0, "b3713762-41a5-47d3-b51d-3e67159abc62", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEGtBDbcMyPTz06BqmgBj3ss+oNVV0BgGSdjB8xxAEZCQep4euImHchjhxREuI2BQog==", null, true, "481953d3-a584-4eac-b745-7f5e03690c29", "Test", false, "admin@zoo-arcadia.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "5e162906-6d18-4189-9ad8-d53b33497507" },
                    { "0", "fac71d72-5e8a-4404-9851-a1658c816082" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "5e162906-6d18-4189-9ad8-d53b33497507" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "fac71d72-5e8a-4404-9851-a1658c816082" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e162906-6d18-4189-9ad8-d53b33497507");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fac71d72-5e8a-4404-9851-a1658c816082");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "40ce474f-16ec-45c9-8b5e-aed04d5db56a", 0, "e4bb0392-849b-457c-bbba-021f2fa52481", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAECDzRhJ2EswKwWcavah1/BVGAULsi+3g88ZWRsppc5KRJ+PEm3fd3scZClrMSF1xqg==", null, true, "399936d7-57bb-4c24-be1f-87e91bf46e06", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "40ce474f-16ec-45c9-8b5e-aed04d5db56a" });
        }
    }
}
