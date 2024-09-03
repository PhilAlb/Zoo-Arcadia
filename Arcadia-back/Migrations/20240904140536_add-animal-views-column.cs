using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class addanimalviewscolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Views",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Views",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "Views",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Views",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "Views",
                value: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4974ed59-2efc-4d6c-b03b-71470d2df81f", 0, "9d93f099-e4d2-4cc7-93bc-7f01e1eb6ae6", "employee@zoo-arcadia.com", true, false, null, "Employé", "EMPLOYEE@ZOO-ARCADIA.COM", "EMPLOYEE@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEJ2NqW89EGYVsO339U86OKcFAVDU+GT2lvcwQ3hZ4t8HLvc+ttt+eieUbyubTzmPog==", null, true, "5488ef4d-fae7-4f7f-99a2-208b1ca64dfb", "Test", false, "employee@zoo-arcadia.com" },
                    { "84f9522e-cfee-4f0f-a91b-2820ee51c0da", 0, "35b5ee09-68a7-42e4-aa6a-a1abe06c4e71", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEMz685dlf/qcyxLupTkZsFmMQPcHzQoEbW20Bt1ALkNwkb21SI+3Mqse6wPJGqB98Q==", null, true, "2f3f2e15-8dc5-48e1-a539-d3898db21026", "Test", false, "admin@zoo-arcadia.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2", "4974ed59-2efc-4d6c-b03b-71470d2df81f" },
                    { "0", "84f9522e-cfee-4f0f-a91b-2820ee51c0da" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "4974ed59-2efc-4d6c-b03b-71470d2df81f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "84f9522e-cfee-4f0f-a91b-2820ee51c0da" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4974ed59-2efc-4d6c-b03b-71470d2df81f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84f9522e-cfee-4f0f-a91b-2820ee51c0da");

            migrationBuilder.DropColumn(
                name: "Views",
                table: "Animals");

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
    }
}
