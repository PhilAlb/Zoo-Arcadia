public class ServiceDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Schedules { get; set; }
    public IFormFile? Image { get; set; }
    public string? ImageUrl { get; set; }
}
