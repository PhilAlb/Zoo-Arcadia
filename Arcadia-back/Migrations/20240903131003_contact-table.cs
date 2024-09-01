using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class contacttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "98e31e9c-89f0-4597-ab19-76f5bde8b5cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98e31e9c-89f0-4597-ab19-76f5bde8b5cd");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "69a57aed-b435-4fba-9c53-704224aa236f", 0, "c67b1e5d-3e67-479b-b829-6afa98660e68", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEC12aSd2hprlRAcMn2NRFtUIQvGo+FO0a+nbWZKLlnec99RXnmPipgXt/4NItWtq6g==", null, true, "fb05a915-68f1-46ca-995c-7dee0c369801", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "69a57aed-b435-4fba-9c53-704224aa236f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

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
                values: new object[] { "98e31e9c-89f0-4597-ab19-76f5bde8b5cd", 0, "4cd2a977-a99b-45a5-8f88-fc6e6a48592c", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAECtZ2bEcdHsizrHtxmvAsi1rX45OzM75ipk64rMYmnSNT/WzNxh3YRtjJVtoRqOeFA==", null, true, "213499e5-3c13-453f-937f-f422bbd3afe8", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "98e31e9c-89f0-4597-ab19-76f5bde8b5cd" });
        }
    }
}
