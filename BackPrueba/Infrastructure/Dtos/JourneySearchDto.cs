using System.ComponentModel.DataAnnotations;

namespace BackPrueba.Infrastructure.Dtos
{
    public class JourneySearchDto
    {
        [Required]
        [MaxLength(3)]
        public string Origin { get; set; }

        [Required]
        [MaxLength(3)]
        public string Destination { get; set; }
    }
}
