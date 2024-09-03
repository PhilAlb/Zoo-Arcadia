using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class runcontactmethod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "cae4d28e-ff0b-4757-811f-b3e3e0aeae06", 0, "e3f228fe-da51-4eb9-b3fa-38ad4cd6169a", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEAN552/LDbZAJ8nsZpueeNkd823WYuQw9RCIW964EQTBVxlOkUnEvBWYC0Squb9Meg==", null, true, "8717234c-82db-4155-9df8-1384fed6e015", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Message", "Title" },
                values: new object[,]
                {
                    { 1, "jean-francois.labrosse@mail.com", "Le zoo sera-t-il ouvert le 14 juillet ?", "Ouverture le 14 juillet" },
                    { 2, "manon-fournier@mail.com", "Proposez-vous des stages de soin aux animaux à destination des enfants ?", "Stage de soin aux animaux" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "cae4d28e-ff0b-4757-811f-b3e3e0aeae06" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "cae4d28e-ff0b-4757-811f-b3e3e0aeae06" });

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cae4d28e-ff0b-4757-811f-b3e3e0aeae06");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "279ac1ee-8abc-4248-80ef-65e82b1d08ba", 0, "0cf184b1-668a-4c7d-a0c0-d5fe83a3f23b", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEGYRpFCBsy287bIhNRvwsz4qUbgvcZt2eY3aK95Y2jsJRihmNS9MWhNYBLq7OGKzWw==", null, true, "d93b3ec8-4fc3-4133-b094-af0410473fb5", "Test", false, "admin@zoo-arcadia.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "279ac1ee-8abc-4248-80ef-65e82b1d08ba" });
        }
    }
}
