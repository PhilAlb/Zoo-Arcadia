using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class updated_testimony_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Testimonies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Testimonies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "\"Un après-midi magique\"");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "\"Zoo immense\"");

            migrationBuilder.UpdateData(
                table: "Testimonies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "\"Superbe zoo\"");
        }
    }
}
