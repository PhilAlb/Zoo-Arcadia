namespace ArcadiaBack
{
    public class Habitat
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ImageVerticalPosition { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }

    public class HabitatDto
    {
        public int Id {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile? Image { get; set; }
        public string? ImageUrl { get; set; }
    }
}