using System.ComponentModel.DataAnnotations.Schema;

namespace ArcadiaBack
{
    public class AnimalList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string ImageUrl { get; set; }
        public int ? HabitatId { get; set; }
    }
}