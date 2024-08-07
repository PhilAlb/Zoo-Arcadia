using System.ComponentModel.DataAnnotations;

namespace Arcadia_back.models.Dtos
{
    public class CardTestimonyDto
    {
        [Required]
        public string Pseudo { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
