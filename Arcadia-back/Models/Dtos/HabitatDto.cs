public class HabitatDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string? Comment { get; set; }
    public IFormFile? Image { get; set; }
    public string? ImageUrl { get; set; }
}
