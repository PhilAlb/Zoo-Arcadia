
public class AnimalDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Race { get; set; }
    public int Views { get; set; }
    public string? Comment { get; set; }
    public IFormFile? Image { get; set; }
    public string? ImageUrl { get; set; }
    public string? AssociatedHabitatTitle { get; set; }
    public int? AssociatedHabitatId { get; set; }
}