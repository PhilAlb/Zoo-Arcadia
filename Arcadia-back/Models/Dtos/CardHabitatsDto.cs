using System.ComponentModel.DataAnnotations;

namespace Arcadia_back.models.Dtos
{
    public class CardHabitatsDto : CardDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public string Animals { get; set; }


    }
}
