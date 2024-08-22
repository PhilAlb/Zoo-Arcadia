using System.ComponentModel.DataAnnotations.Schema;

namespace ArcadiaBack
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string ImageUrl { get; set; }

        public Habitat? AssociatedHabitat { get; set; }
        [ForeignKey(nameof(AssociatedHabitat))]
        public int? AssociatedHabitatId { get; set; }
    }
}
