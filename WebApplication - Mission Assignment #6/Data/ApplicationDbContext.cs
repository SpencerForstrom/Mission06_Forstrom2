using Microsoft.EntityFrameworkCore;
using WebApplication___Mission_Assignment__6.Models;

namespace WebApplication___Mission_Assignment__6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        // Add pre-made rows to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Call base method to ensure default behavior

            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "12 Angry Men", Year = 1957, Director = "Sidney Lumet", Rating = "Not Rated", Edited = false },
                new Movie { MovieId = 2, Title = "The Dark Knight", Year = 2008, Director = "Christopher Nolan", Rating = "PG-13", Edited = false },
                new Movie { MovieId = 3, Title = "Good Will Hunting", Year = 1997, Director = "Gus Van Sant", Rating = "R", Edited = false }
            );
        }
    }
}
