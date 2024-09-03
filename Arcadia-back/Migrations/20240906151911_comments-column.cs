using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class commentscolumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalFoodHistory");

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

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "Comment",
                value: "");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                column: "Comment",
                value: "");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "Comment",
                value: "");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "Comment",
                value: "");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                column: "Comment",
                value: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Veterinarian", "VETERINARIAN" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Animals");

            migrationBuilder.CreateTable(
                name: "AnimalFoodHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodWeight = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalFoodHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalFoodHistory_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "User", "USER" });

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

            migrationBuilder.CreateIndex(
                name: "IX_AnimalFoodHistory_AnimalId",
                table: "AnimalFoodHistory",
                column: "AnimalId");
        }
    }
}
