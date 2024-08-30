using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class animalsnamesupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "c4702ab9-c283-4d2b-85e4-c23da10dc525" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4702ab9-c283-4d2b-85e4-c23da10dc525");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Race" },
                values: new object[] { "Mufasa", "Lion" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssociatedHabitatId", "Name", "Race" },
                values: new object[] { 2, "Sherkan", "Tigre" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssociatedHabitatId", "Name", "Race" },
                values: new object[] { 2, "Louis", "Singe" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Race" },
                values: new object[] { "Po", "Panda" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssociatedHabitatId", "Name", "Race" },
                values: new object[] { 3, "Angèle", "Loutre" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8583946-e01f-4f8e-92e7-0bf6082bb30a", 0, "1cf9e6ce-8e87-45d5-8075-6361482817f6", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEBVXWnoWgi55dRr4Re5gtYUDMnsI/trf4wRS2pYkBf22Ye7Pt6CmYfQwaX1VWsv3gw==", null, true, "73f446ce-e36e-489c-b55d-0cd41997bfdf", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "e8583946-e01f-4f8e-92e7-0bf6082bb30a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 1,
                columns: new[] { "Name", "Race" },
                values: new object[] { "lion", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssociatedHabitatId", "Name", "Race" },
                values: new object[] { 1, "tiger", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AssociatedHabitatId", "Name", "Race" },
                values: new object[] { 1, "monkey", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Race" },
                values: new object[] { "panda", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AssociatedHabitatId", "Name", "Race" },
                values: new object[] { 1, "outter", "Unknown" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c4702ab9-c283-4d2b-85e4-c23da10dc525", 0, "58d6aa14-19f5-47cc-8eb6-6ee6e432c024", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEDyOVoH2fXb3xZY7YBGvxskeUpN81c998Qm0x73ha0W31U5602trT+KIPxdT44Xv4Q==", null, true, "4cfeb8ce-6798-4888-a972-505edbca952e", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "c4702ab9-c283-4d2b-85e4-c23da10dc525" });
        }
    }
}
