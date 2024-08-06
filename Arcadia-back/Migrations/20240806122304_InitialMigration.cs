using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Arcadia_back.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habitats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageVerticalPosition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Schedules = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageVerticalPosition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssociatedHabitatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Habitats_AssociatedHabitatId",
                        column: x => x.AssociatedHabitatId,
                        principalTable: "Habitats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnimalFoodHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalId = table.Column<int>(type: "int", nullable: false),
                    FoodWeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Habitats",
                columns: new[] { "Id", "Description", "ImageUrl", "ImageVerticalPosition", "Title" },
                values: new object[,]
                {
                    { 1, "La savane est caractérisée par de vastes plaines herbeuses et les paysages ouverts d'Afrique. Les paysages offrent une végétation clairsemée, principalement composée de hautes herbes, d'arbustes et de quelques arbres dispersés. La savane est connue pour ses climats chauds et ses saisons alternant entre des périodes sèches et des périodes de pluies intenses.", "assets/images/habitats/savannah1.jpg", "30%", "Savane" },
                    { 2, "La jungle est caractérisée par une végétation dense avec des arbres à canopée élevée, des lianes enchevêtrées, et des fougères luxuriantes. Des cascades et des ruisseaux serpentent à travers la forêt, apportant une ambiance sonore apaisante de l'eau en mouvement.", "assets/images/habitats/jungle1.webp", "55%", "Jungle" },
                    { 3, "Les marais sont caractérisés par des zones humides situées à la transition entre les écosystèmes aquatiques et terrestres, offrant un refuge crucial pour de nombreuses espèces. Découvrez cet environnement riche et diversifié, où chaque coin regorge de vie et de mystères.", "assets/images/habitats/swamp1.jpg", "50%", "Marais" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "ImageUrl", "ImageVerticalPosition", "Schedules", "Title" },
                values: new object[,]
                {
                    { 1, "Découvrez notre offre de restauration avec des plats délicieux et variés pour tous les goûts. Notre restaurant propose une sélection de mets allant des sandwichs rapides aux repas gastronomiques. Nous utilisons des ingrédients frais et locaux pour garantir une qualité optimale.", "assets/images/services/restauration1.webp", "70%", "Lundi-Dimanche: 10h00 - 20h00", "Restauration" },
                    { 2, "Participez à nos visites guidées gratuites pour découvrir les secrets du zoo et de ses habitants. Nos guides experts vous emmèneront à travers les différentes sections du zoo, vous donnant un aperçu unique de la vie des animaux et de leur habitat naturel. Lors de la visite, vous apprendrez des faits fascinants sur les animaux, leurs comportements, et leurs histoires individuelles. Vous aurez également l'occasion d'assister à des sessions d'alimentation et à des présentations éducatives qui ne sont pas disponibles pour le public général.", "assets/images/services/visit1.jpg", "35%", "Lundi-Samedi: 10h00 - 18h00", "Visite guidée" },
                    { 3, "Profitez d'une visite confortable et amusante à bord de notre petit train à travers le zoo. Cette expérience est idéale pour les familles avec enfants, les personnes âgées ou toute personne souhaitant découvrir le zoo sans trop marcher. Le petit train vous emmènera dans un voyage pittoresque à travers les différentes zones du zoo, vous offrant une vue d'ensemble de nos attractions principales. Vous passerez par les enclos des animaux, les jardins paysagers, et les zones de jeux pour enfants.", "assets/images/services/train1.webp", "65%", "Lundi-Vendredi: 10h00 - 16h00", "Visite en train" }
                });

            migrationBuilder.InsertData(
                table: "Testimonies",
                columns: new[] { "Id", "Message", "Title", "Username" },
                values: new object[,]
                {
                    { 1, "Un après-midi magique dans un zoo immersif qui nous permet d'être au plus près des animaux de les voir évoluer dans un cadre 100 % adapté. Leur histoire touchante nous est comptée sur les panneaux d'information tout au long du parc.", "\"Un après-midi magique\"", "Unknown" },
                    { 2, "Zoo immense, les animaux semblent très bien traités, on a vu le personnel au petits soins et tendre avec les animaux notamment avec les singes qui le rendent donc super ambiance, et moment agréable en famille. Tarif abordable.", "\"Zoo immense\"", "Unknown" },
                    { 3, "Superbe zoo. Des enclos bien entretenus et des grands espaces. Des animaux en bonne santé et beaucoup d'espèces. Espace pique nique, toilettes, buvettes, snack et boutique dans le parc. Je recommande fortement !", "\"Superbe zoo\"", "Unknown" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AssociatedHabitatId", "ImageUrl", "Name", "Race" },
                values: new object[,]
                {
                    { 1, 1, "assets/images/carousel/lion1.jpg", "lion", "Unknown" },
                    { 2, 1, "assets/images/carousel/tiger1.jpg", "tiger-image", "Unknown" },
                    { 3, 1, "assets/images/carousel/monkey1.jpg", "monkey-image", "Unknown" },
                    { 4, 1, "assets/images/carousel/panda1.jpg", "panda-image", "Unknown" },
                    { 5, 1, "assets/images/carousel/outter1.jpg", "outter-image", "Unknown" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalFoodHistory_AnimalId",
                table: "AnimalFoodHistory",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AssociatedHabitatId",
                table: "Animals",
                column: "AssociatedHabitatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalFoodHistory");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Testimonies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Habitats");
        }
    }
}
