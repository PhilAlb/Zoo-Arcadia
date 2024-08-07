﻿// <auto-generated />
using Arcadia_back.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Arcadia_back.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ArcadiaBack.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssociatedHabitatId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssociatedHabitatId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssociatedHabitatId = 1,
                            ImageUrl = "assets/images/carousel/lion1.jpg",
                            Name = "lion",
                            Race = "Unknown"
                        },
                        new
                        {
                            Id = 2,
                            AssociatedHabitatId = 1,
                            ImageUrl = "assets/images/carousel/tiger1.jpg",
                            Name = "tiger-image",
                            Race = "Unknown"
                        },
                        new
                        {
                            Id = 3,
                            AssociatedHabitatId = 1,
                            ImageUrl = "assets/images/carousel/monkey1.jpg",
                            Name = "monkey-image",
                            Race = "Unknown"
                        },
                        new
                        {
                            Id = 4,
                            AssociatedHabitatId = 1,
                            ImageUrl = "assets/images/carousel/panda1.jpg",
                            Name = "panda-image",
                            Race = "Unknown"
                        },
                        new
                        {
                            Id = 5,
                            AssociatedHabitatId = 1,
                            ImageUrl = "assets/images/carousel/outter1.jpg",
                            Name = "outter-image",
                            Race = "Unknown"
                        });
                });

            modelBuilder.Entity("ArcadiaBack.AnimalFoodHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodWeight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("AnimalFoodHistory");
                });

            modelBuilder.Entity("ArcadiaBack.Habitat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageVerticalPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Habitats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "La savane est caractérisée par de vastes plaines herbeuses et les paysages ouverts d'Afrique. Les paysages offrent une végétation clairsemée, principalement composée de hautes herbes, d'arbustes et de quelques arbres dispersés. La savane est connue pour ses climats chauds et ses saisons alternant entre des périodes sèches et des périodes de pluies intenses.",
                            ImageUrl = "assets/images/habitats/savannah1.jpg",
                            ImageVerticalPosition = "30%",
                            Title = "Savane"
                        },
                        new
                        {
                            Id = 2,
                            Description = "La jungle est caractérisée par une végétation dense avec des arbres à canopée élevée, des lianes enchevêtrées, et des fougères luxuriantes. Des cascades et des ruisseaux serpentent à travers la forêt, apportant une ambiance sonore apaisante de l'eau en mouvement.",
                            ImageUrl = "assets/images/habitats/jungle1.webp",
                            ImageVerticalPosition = "55%",
                            Title = "Jungle"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Les marais sont caractérisés par des zones humides situées à la transition entre les écosystèmes aquatiques et terrestres, offrant un refuge crucial pour de nombreuses espèces. Découvrez cet environnement riche et diversifié, où chaque coin regorge de vie et de mystères.",
                            ImageUrl = "assets/images/habitats/swamp1.jpg",
                            ImageVerticalPosition = "50%",
                            Title = "Marais"
                        });
                });

            modelBuilder.Entity("ArcadiaBack.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageVerticalPosition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Découvrez notre offre de restauration avec des plats délicieux et variés pour tous les goûts. Notre restaurant propose une sélection de mets allant des sandwichs rapides aux repas gastronomiques. Nous utilisons des ingrédients frais et locaux pour garantir une qualité optimale.",
                            ImageUrl = "assets/images/services/restauration1.webp",
                            ImageVerticalPosition = "70%",
                            Schedules = "Lundi-Dimanche: 10h00 - 20h00",
                            Title = "Restauration"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Participez à nos visites guidées gratuites pour découvrir les secrets du zoo et de ses habitants. Nos guides experts vous emmèneront à travers les différentes sections du zoo, vous donnant un aperçu unique de la vie des animaux et de leur habitat naturel. Lors de la visite, vous apprendrez des faits fascinants sur les animaux, leurs comportements, et leurs histoires individuelles. Vous aurez également l'occasion d'assister à des sessions d'alimentation et à des présentations éducatives qui ne sont pas disponibles pour le public général.",
                            ImageUrl = "assets/images/services/visit1.jpg",
                            ImageVerticalPosition = "35%",
                            Schedules = "Lundi-Samedi: 10h00 - 18h00",
                            Title = "Visite guidée"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Profitez d'une visite confortable et amusante à bord de notre petit train à travers le zoo. Cette expérience est idéale pour les familles avec enfants, les personnes âgées ou toute personne souhaitant découvrir le zoo sans trop marcher. Le petit train vous emmènera dans un voyage pittoresque à travers les différentes zones du zoo, vous offrant une vue d'ensemble de nos attractions principales. Vous passerez par les enclos des animaux, les jardins paysagers, et les zones de jeux pour enfants.",
                            ImageUrl = "assets/images/services/train1.webp",
                            ImageVerticalPosition = "65%",
                            Schedules = "Lundi-Vendredi: 10h00 - 16h00",
                            Title = "Visite en train"
                        });
                });

            modelBuilder.Entity("ArcadiaBack.Testimony", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Testimonies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Message = "Un après-midi magique dans un zoo immersif qui nous permet d'être au plus près des animaux de les voir évoluer dans un cadre 100 % adapté. Leur histoire touchante nous est comptée sur les panneaux d'information tout au long du parc.",
                            Pseudo = "Eric"
                        },
                        new
                        {
                            Id = 2,
                            Message = "Zoo immense, les animaux semblent très bien traités, on a vu le personnel au petits soins et tendre avec les animaux notamment avec les singes qui le rendent donc super ambiance, et moment agréable en famille. Tarif abordable.",
                            Pseudo = "Laura"
                        },
                        new
                        {
                            Id = 3,
                            Message = "Superbe zoo. Des enclos bien entretenus et des grands espaces. Des animaux en bonne santé et beaucoup d'espèces. Espace pique nique, toilettes, buvettes, snack et boutique dans le parc. Je recommande fortement !",
                            Pseudo = "Justine"
                        });
                });

            modelBuilder.Entity("ArcadiaBack.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ArcadiaBack.Animal", b =>
                {
                    b.HasOne("ArcadiaBack.Habitat", "AssociatedHabitat")
                        .WithMany("Animals")
                        .HasForeignKey("AssociatedHabitatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssociatedHabitat");
                });

            modelBuilder.Entity("ArcadiaBack.AnimalFoodHistory", b =>
                {
                    b.HasOne("ArcadiaBack.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("ArcadiaBack.Habitat", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
