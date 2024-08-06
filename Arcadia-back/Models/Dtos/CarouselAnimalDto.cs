using System.ComponentModel.DataAnnotations;

namespace Arcadia_back.models.Dtos
{
    public class CarouselAnimalDto
    {
        [Required]
        public string AnimalName { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
