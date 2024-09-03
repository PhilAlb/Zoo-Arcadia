using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class habitatcommentcolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1167f390-c540-4744-8893-97217468d0bc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "507a7807-ec92-48d3-87f3-132d13384acf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "82d99c16-0c6a-481d-a424-3df2de7b0bfc" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1167f390-c540-4744-8893-97217468d0bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "507a7807-ec92-48d3-87f3-132d13384acf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82d99c16-0c6a-481d-a424-3df2de7b0bfc");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Habitats",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d627fdf-4f8b-4f0b-ab3f-c90c80b26ac2", 0, "22dac547-485f-45df-9e6c-4a8d7756e060", "veterinarian@zoo-arcadia.com", true, false, null, "Vétérinaire", "VETERINARIAN@ZOO-ARCADIA.COM", "VETERINARIAN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAECrzzQy+hEpoJPYKG1CobT8ttPZy0GSxqmDpqJ4sDg6++LHYqDoOcZUfaXw/sI1zog==", null, true, "f9922863-5be9-4630-94c7-40428c8a3d06", "Test", false, "veterinarian@zoo-arcadia.com" },
                    { "43fb1563-ed88-4cb0-b719-05302ee30694", 0, "d0740f37-08dd-45d6-ae25-00d2f957b750", "employee@zoo-arcadia.com", true, false, null, "Employé", "EMPLOYEE@ZOO-ARCADIA.COM", "EMPLOYEE@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAENnz0NHA29reEFq6HIn7z5hWv+Xiz2bNEi63bG3CyHcou0lHAI98Fb9oFWZ6+h4PFw==", null, true, "e5af5974-a4e9-415d-9d28-799de0ae28c7", "Test", false, "employee@zoo-arcadia.com" },
                    { "45d42d9c-4d65-45c5-b755-e24a6f599ebd", 0, "9fecd79a-3ff7-4f22-b7fd-c4ea9f472946", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEFQF4u/ykNgQY+Iz9D0DxLUJWNwMBioWSgz02gJSF3iyfeE7HZMbR1nfgWp4wVIQJA==", null, true, "39988017-c1ba-409f-a0bd-63f1d330d985", "Test", false, "admin@zoo-arcadia.com" }
                });

            migrationBuilder.UpdateData(
                table: "Habitats",
                keyColumn: "Id",
                keyValue: 1,
                column: "Comment",
                value: "");

            migrationBuilder.UpdateData(
                table: "Habitats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Comment",
                value: "");

            migrationBuilder.UpdateData(
                table: "Habitats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Comment",
                value: "");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "0d627fdf-4f8b-4f0b-ab3f-c90c80b26ac2" },
                    { "2", "43fb1563-ed88-4cb0-b719-05302ee30694" },
                    { "0", "45d42d9c-4d65-45c5-b755-e24a6f599ebd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "0d627fdf-4f8b-4f0b-ab3f-c90c80b26ac2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "43fb1563-ed88-4cb0-b719-05302ee30694" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "45d42d9c-4d65-45c5-b755-e24a6f599ebd" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d627fdf-4f8b-4f0b-ab3f-c90c80b26ac2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43fb1563-ed88-4cb0-b719-05302ee30694");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45d42d9c-4d65-45c5-b755-e24a6f599ebd");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Habitats");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1167f390-c540-4744-8893-97217468d0bc", 0, "f566aa82-0d13-45d2-9102-9c55c5d3e398", "veterinarian@zoo-arcadia.com", true, false, null, "Vétérinaire", "VETERINARIAN@ZOO-ARCADIA.COM", "VETERINARIAN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEEP47zzPlndhDLKItyuxYkz0EW/rkAv7yezm+DZWMtoS886FXMDi4qt6C9T2ditWPA==", null, true, "1085665f-a9b3-4ab3-ba2e-fff8e0b1bc3b", "Test", false, "veterinarian@zoo-arcadia.com" },
                    { "507a7807-ec92-48d3-87f3-132d13384acf", 0, "a5194356-d830-4608-b9e0-a854037c64a5", "admin@zoo-arcadia.com", true, false, null, "Admin", "ADMIN@ZOO-ARCADIA.COM", "ADMIN@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEN2jihnLjIyWY74sl+6MuP7kgeTeAT7vau7HAU6UZKwNwapC9Y0VwsoNwxqtsANw7Q==", null, true, "fbee49a8-b37c-45af-8f0b-de217f0a1ba3", "Test", false, "admin@zoo-arcadia.com" },
                    { "82d99c16-0c6a-481d-a424-3df2de7b0bfc", 0, "8f2dffbe-5e1a-4849-be8e-cf01a1223fba", "employee@zoo-arcadia.com", true, false, null, "Employé", "EMPLOYEE@ZOO-ARCADIA.COM", "EMPLOYEE@ZOO-ARCADIA.COM", "AQAAAAIAAYagAAAAEFucTmCyDmnAQLQjXpZGyAfe4C0LXJ/WRYXL4rbfuiSQ9b5NnRfxhxZIMHRsqXYNuQ==", null, true, "b6dd3199-039c-4580-8531-5597cf204cd7", "Test", false, "employee@zoo-arcadia.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1167f390-c540-4744-8893-97217468d0bc" },
                    { "0", "507a7807-ec92-48d3-87f3-132d13384acf" },
                    { "2", "82d99c16-0c6a-481d-a424-3df2de7b0bfc" }
                });
        }
    }
}
