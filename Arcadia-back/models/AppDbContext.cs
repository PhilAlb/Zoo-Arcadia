using ArcadiaBack;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Arcadia_back.models
{
    public class AppDbContext : IdentityDbContext<User>
    {
        private readonly IConfiguration _configuration;

        public AppDbContext(DbContextOptions<AppDbContext> options,
            IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalFoodHistory> AnimalFoodHistory { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Testimony> Testimonies { get; set; }
        public DbSet<Habitat> Habitats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Value"));
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Used to generate initial data for database
            GenerateAnimalSeeed(modelBuilder);
            GenerateHabitatSeed(modelBuilder);
            GenerateServiceSeed(modelBuilder);
            GenerateTestimonySeed(modelBuilder);
            GenerateAdminUserSeed(modelBuilder);
        }

        private void GenerateAdminUserSeed(ModelBuilder modelBuilder)
        {
            // Seed roles
            var adminRoleId = "0";
            var adminUserId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = Role.Admin.ToString(),
                    NormalizedName = Role.Admin.ToString().ToUpper(),
                },
                new IdentityRole
                {
                    Id = "1",
                    Name = Role.User.ToString(),
                    NormalizedName = Role.User.ToString().ToUpper(),
                }
            );

            // Seed the admin user
            var hasher = new PasswordHasher<User>();
            var mail = "admin@zoo-arcadia.com";
            var user = new User()
            {
                Id = adminUserId,
                Name = "Admin",
                Surname = "Test",
                UserName = mail,
                NormalizedUserName = mail.ToUpper(),
                Email = mail,
                NormalizedEmail = mail.ToUpper(),
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                AccessFailedCount = 0,
                LockoutEnabled = false,
                TwoFactorEnabled = false,
            };
            user.PasswordHash = hasher.HashPassword(user, "Admin0001");

            modelBuilder.Entity<User>().HasData(user);

            // Assign admin user to admin role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = adminUserId,
                    RoleId = adminRoleId
                }
            );
        }

        private void GenerateAnimalSeeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
                new()
                {
                    Id = 1,
                    ImageUrl = "assets/images/animals/lion1.jpg",
                    Name = "lion",
                    Race = "Unknown",
                    AssociatedHabitatId = 1
                },
                new()
                {
                    Id = 2,
                    ImageUrl = "assets/images/animals/tiger1.jpg",
                    Name = "tiger",
                    Race = "Unknown",
                    AssociatedHabitatId = 1,
                },
                new()
                {
                    Id = 3,
                    ImageUrl = "assets/images/animals/monkey1.jpg",
                    Name = "monkey",
                    Race = "Unknown",
                    AssociatedHabitatId = 1,
                },
                new()
                {
                    Id = 4,
                    ImageUrl = "assets/images/animals/panda1.jpg",
                    Name = "panda",
                    Race = "Unknown",
                    AssociatedHabitatId = 1,
                }, new()
                {
                    Id = 5,
                    ImageUrl = "assets/animals/outter1.jpg",
                    Name = "outter",
                    Race = "Unknown",
                    AssociatedHabitatId = 1,
                });
        }

        private void GenerateHabitatSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habitat>().HasData(
                new()
                {
                    Id = 1,
                    Title = "Savane",
                    Description = "La savane est caractérisée par de vastes plaines herbeuses et les paysages ouverts d'Afrique. Les paysages offrent une végétation clairsemée, principalement composée de hautes herbes, d'arbustes et de quelques arbres dispersés. La savane est connue pour ses climats chauds et ses saisons alternant entre des périodes sèches et des périodes de pluies intenses.",
                    ImageUrl = "assets/images/habitats/savannah1.jpg",
                    ImageVerticalPosition = "30%",
                },
                new()
                {
                    Id = 2,
                    Title = "Jungle",
                    Description = "La jungle est caractérisée par une végétation dense avec des arbres à canopée élevée, des lianes enchevêtrées, et des fougères luxuriantes. Des cascades et des ruisseaux serpentent à travers la forêt, apportant une ambiance sonore apaisante de l'eau en mouvement.",
                    ImageUrl = "assets/images/habitats/jungle1.webp",
                    ImageVerticalPosition = "55%",
                },
                new()
                {
                    Id = 3,
                    Title = "Marais",
                    Description = "Les marais sont caractérisés par des zones humides situées à la transition entre les écosystèmes aquatiques et terrestres, offrant un refuge crucial pour de nombreuses espèces. Découvrez cet environnement riche et diversifié, où chaque coin regorge de vie et de mystères.",
                    ImageUrl = "assets/images/habitats/swamp1.jpg",
                    ImageVerticalPosition = "50%",
                }
            );
        }

        private void GenerateServiceSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new()
                {
                    Id = 1,
                    Title = "Restauration",
                    Description = "Découvrez notre offre de restauration avec des plats délicieux et variés pour tous les goûts. Notre restaurant propose une sélection de mets allant des sandwichs rapides aux repas gastronomiques. Nous utilisons des ingrédients frais et locaux pour garantir une qualité optimale.",
                    ImageUrl = "assets/images/services/restauration1.webp",
                    ImageVerticalPosition = "70%",
                    Schedules = "Lundi-Dimanche: 10h00 - 20h00"
                },
                new()
                {
                    Id = 2,
                    Title = "Visite guidée",
                    Description = "Participez à nos visites guidées gratuites pour découvrir les secrets du zoo et de ses habitants. Nos guides experts vous emmèneront à travers les différentes sections du zoo, vous donnant un aperçu unique de la vie des animaux et de leur habitat naturel. Lors de la visite, vous apprendrez des faits fascinants sur les animaux, leurs comportements, et leurs histoires individuelles. Vous aurez également l'occasion d'assister à des sessions d'alimentation et à des présentations éducatives qui ne sont pas disponibles pour le public général.",
                    ImageUrl = "assets/images/services/visit1.jpg",
                    ImageVerticalPosition = "35%",
                    Schedules = "Lundi-Samedi: 10h00 - 18h00"
                },
                new()
                {
                    Id = 3,
                    Title = "Visite en train",
                    Description = "Profitez d'une visite confortable et amusante à bord de notre petit train à travers le zoo. Cette expérience est idéale pour les familles avec enfants, les personnes âgées ou toute personne souhaitant découvrir le zoo sans trop marcher. Le petit train vous emmènera dans un voyage pittoresque à travers les différentes zones du zoo, vous offrant une vue d'ensemble de nos attractions principales. Vous passerez par les enclos des animaux, les jardins paysagers, et les zones de jeux pour enfants.",
                    ImageUrl = "assets/images/services/train1.webp",
                    ImageVerticalPosition = "65%",
                    Schedules = "Lundi-Vendredi: 10h00 - 16h00"
                }
            );
        }

        private void GenerateTestimonySeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Testimony>().HasData(
                new()
                {
                    Id = 1,
                    Message = "Un après-midi magique dans un zoo immersif qui nous permet d'être au plus près des animaux de les voir évoluer dans un cadre 100 % adapté. Leur histoire touchante nous est comptée sur les panneaux d'information tout au long du parc.",
                    Pseudo = "Eric"
                },
                new()
                {
                    Id = 2,
                    Message = "Zoo immense, les animaux semblent très bien traités, on a vu le personnel au petits soins et tendre avec les animaux notamment avec les singes qui le rendent donc super ambiance, et moment agréable en famille. Tarif abordable.",
                    Pseudo = "Laura"
                },
                new()
                {
                    Id = 3,
                    Message = "Superbe zoo. Des enclos bien entretenus et des grands espaces. Des animaux en bonne santé et beaucoup d'espèces. Espace pique nique, toilettes, buvettes, snack et boutique dans le parc. Je recommande fortement !",
                    Pseudo = "Justine"
                }
            );
        }
    }
}