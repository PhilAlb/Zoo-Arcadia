using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class update_pseudo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Testimonies",
                newName: "Pseudo");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Pseudo",
                value: "Eric");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Pseudo",
                value: "Laura");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Pseudo",
                value: "Justine");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pseudo",
                table: "Testimonies",
                newName: "Username");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Username",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Username",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Username",
                value: "Unknown");
        }
    }
}
