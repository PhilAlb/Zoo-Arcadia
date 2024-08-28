using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class migrationrepo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "assets/images/animals/lion1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "assets/images/animals/tiger1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "assets/images/animals/monkey1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "assets/images/animals/panda1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "assets/animals/outter1.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "assets/images/carousel/lion1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "assets/images/carousel/tiger1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "assets/images/carousel/monkey1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "assets/images/carousel/panda1.jpg");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "assets/images/carousel/outter1.jpg");
        }
    }
}
