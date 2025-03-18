using System.ComponentModel.DataAnnotations;

namespace WebApplication___Mission_Assignment__6.Models
{
    // Movie.cs
    // This model is for a movie in the database.
    public class Movie
    {
        [Key]
        /// <summary>
        /// The unique identifier for each movie (Primary Key).
        /// </summary>
        public int MovieId { get; set; }

        /// <summary>
        /// The title of the movie.
        /// This field is required.
        /// </summary>
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        /// <summary>
        /// The year the movie was released.
        /// Must be 1888 or later.
        /// </summary>
        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, 2100, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        /// <summary>
        /// Whether the movie has been edited (e.g., for TV or other formats).
        /// This field is required.
        /// </summary>
        [Required(ErrorMessage = "Edited status is required.")]
        public bool Edited { get; set; }

        /// <summary>
        /// The director, rating, and whether the movie is lent to someone.
        /// </summary>
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public string? LentTo { get; set; }

        /// <summary>
        ///  Notes with a max length of 25 characters
        /// </summary>
        [MaxLength(25, ErrorMessage = "Notes cannot exceed 25 characters.")]
        public string? Notes { get; set; }
    }
}
