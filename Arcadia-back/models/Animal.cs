using System.ComponentModel.DataAnnotations.Schema;

namespace ArcadiaBack
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public Habitat AssociatedHabitat { get; set; }
    }
}
