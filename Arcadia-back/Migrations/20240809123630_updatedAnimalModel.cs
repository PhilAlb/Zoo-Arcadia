using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class updatedAnimalModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Habitats_AssociatedHabitatId",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "AssociatedHabitatId",
                table: "Animals",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Habitats_AssociatedHabitatId",
                table: "Animals",
                column: "AssociatedHabitatId",
                principalTable: "Habitats",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Habitats_AssociatedHabitatId",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "AssociatedHabitatId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Habitats_AssociatedHabitatId",
                table: "Animals",
                column: "AssociatedHabitatId",
                principalTable: "Habitats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
