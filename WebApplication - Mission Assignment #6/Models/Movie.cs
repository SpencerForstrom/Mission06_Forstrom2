using System.ComponentModel.DataAnnotations;

namespace WebApplication___Mission_Assignment__6.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, 2100, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Edited status is required.")]
        public bool Edited { get; set; }

        public string? Director { get; set; }
        public string? Rating { get; set; }
        public string? LentTo { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; }
    }
}
