using System.ComponentModel.DataAnnotations;

namespace WebApplication___Mission_Assignment__6.Models
{
    public class Movie
    {
        [Key] // Primary Key
        public int MovieId { get; set; }

        [Required] // Title is required
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string? LentTo { get; set; } // Nullable

        [MaxLength(25)] // Limit Notes to 25 characters
        public string? Notes { get; set; }
    }
}
