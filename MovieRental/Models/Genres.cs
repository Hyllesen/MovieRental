using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Genres
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public byte Id { get; set; }
    }
}