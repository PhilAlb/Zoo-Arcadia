using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class addcontactmessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "69a57aed-b435-4fba-9c53-704224aa236f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69a57aed-b435-4fba-9c53-704224aa236f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "279ac1ee-8abc-4248-80ef-65e82b1d08ba", 0, "0cf184b1-668a-4c7d-a0c0-d5fe83a3f23b", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEGYRpFCBsy287bIhNRvwsz4qUbgvcZt2eY3aK95Y2jsJRihmNS9MWhNYBLq7OGKzWw==", null, true, "d93b3ec8-4fc3-4133-b094-af0410473fb5", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "279ac1ee-8abc-4248-80ef-65e82b1d08ba" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "279ac1ee-8abc-4248-80ef-65e82b1d08ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "279ac1ee-8abc-4248-80ef-65e82b1d08ba");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69a57aed-b435-4fba-9c53-704224aa236f", 0, "c67b1e5d-3e67-479b-b829-6afa98660e68", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEC12aSd2hprlRAcMn2NRFtUIQvGo+FO0a+nbWZKLlnec99RXnmPipgXt/4NItWtq6g==", null, true, "fb05a915-68f1-46ca-995c-7dee0c369801", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "69a57aed-b435-4fba-9c53-704224aa236f" });
        }
    }
}
