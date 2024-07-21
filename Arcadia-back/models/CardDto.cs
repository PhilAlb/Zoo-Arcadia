using System.ComponentModel.DataAnnotations;

namespace ArcadiaBack
{
    public class CardDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }
        public string VerticalPosition {get; set;} = "50%";
    }
}
