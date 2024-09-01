using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class TestimonyValidation : Migration
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

            migrationBuilder.AddColumn<bool>(
                name: "IsValidated",
                table: "Testimonies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4fcfc12c-6809-49f4-8d61-90c7a4c1cc0f", 0, "fbb06795-843a-4257-976a-7e57a970e370", "admin@mail.com", true, false, null, "Admin", "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEIQmFkXIJUDDi6ZoaXHgw1GNR8EIhUrFsrr5tXwpRldsAeCySN0T1Lf8ie4C2v7K2Q==", null, true, "3093125f-0564-4325-8973-48b7772fef5f", "Test", false, "admin@mail.com" });

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsValidated",
                value: true);

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsValidated",
                value: true);

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsValidated",
                value: true);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0", "4fcfc12c-6809-49f4-8d61-90c7a4c1cc0f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0", "4fcfc12c-6809-49f4-8d61-90c7a4c1cc0f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fcfc12c-6809-49f4-8d61-90c7a4c1cc0f");

            migrationBuilder.DropColumn(
                name: "IsValidated",
                table: "Testimonies");

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
