using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    internal class MovieDBContext : DbContext
    {
        //Define the DbSet for Movie entity
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }
        //Configure the database connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Use SQL Server database with the specified connection string
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4O1D65I\SQLEXPRESS;Initial Catalog=MovieDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        //Configure the model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Configure the Movie entity
            //modelBuilder.Entity<Movie>(entity =>
            //{
            //    entity.ToTable("tbl_movies"); // Map to the "tbl_movies" table
            //    entity.HasKey(m => m.MovieId); // Set MovieId as the primary key
            //    entity.Property(m => m.Title).IsRequired().HasMaxLength(50).HasColumnType("varchar"); // Title is required, max length 50, type varchar
            //    entity.Property(m => m.Director).IsRequired().HasMaxLength(50).HasColumnType("varchar"); // Director is required, max length 50, type varchar
            //    entity.Property(m => m.ReleaseDate).HasColumnType("Date"); // ReleaseDate type Date
            //    entity.Property(m => m.Genre).HasMaxLength(20).HasColumnType("varchar"); // Genre max length 20, type varchar
            //    entity.Property(m => m.Rating).HasColumnType("decimal"); // Rating type decimal
            //});
            //seeding data to the Movies table
            modelBuilder.Entity<Movie>().HasData(

                new Movie { MovieId = 1, Title = "Inception", Director = "Christopher Nolan", ReleaseDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Rating = 8.8m },
    new Movie { MovieId = 2, Title = "The Godfather", Director = "Francis Ford Coppola", ReleaseDate = new DateTime(1972, 3, 24), Genre = "Crime", Rating = 9.2m },
    new Movie { MovieId = 3, Title = "Pulp Fiction", Director = "Quentin Tarantino", ReleaseDate = new DateTime(1994, 10, 14), Genre = "Crime", Rating = 8.9m },
    new Movie { MovieId = 4, Title = "The Shawshank Redemption", Director = "Frank Darabont", ReleaseDate = new DateTime(1994, 9, 23), Genre = "Drama", Rating = 9.3m },
    new Movie { MovieId = 5, Title = "Interstellar", Director = "Christopher Nolan", ReleaseDate = new DateTime(2014, 11, 7), Genre = "Sci-Fi", Rating = 8.6m },
    new Movie { MovieId = 6, Title = "Parasite", Director = "Bong Joon-ho", ReleaseDate = new DateTime(2019, 5, 30), Genre = "Thriller", Rating = 8.6m },
    new Movie { MovieId = 7, Title = "Gladiator", Director = "Ridley Scott", ReleaseDate = new DateTime(2000, 5, 5), Genre = "Action", Rating = 8.5m },
    new Movie { MovieId = 8, Title = "Titanic", Director = "James Cameron", ReleaseDate = new DateTime(1997, 12, 19), Genre = "Romance", Rating = 7.8m },
    new Movie { MovieId = 9, Title = "The Matrix", Director = "Lana Wachowski", ReleaseDate = new DateTime(1999, 3, 31), Genre = "Sci-Fi", Rating = 8.7m },
    new Movie { MovieId = 10, Title = "Avengers: Endgame", Director = "Anthony Russo", ReleaseDate = new DateTime(2019, 4, 26), Genre = "Superhero", Rating = 8.4m },
    new Movie { MovieId = 11, Title = "Joker", Director = "Todd Phillips", ReleaseDate = new DateTime(2019, 10, 4), Genre = "Drama", Rating = 8.5m },
    new Movie { MovieId = 12, Title = "Forrest Gump", Director = "Robert Zemeckis", ReleaseDate = new DateTime(1994, 7, 6), Genre = "Drama", Rating = 8.8m },
    new Movie { MovieId = 13, Title = "Fight Club", Director = "David Fincher", ReleaseDate = new DateTime(1999, 10, 15), Genre = "Drama", Rating = 8.8m },
    new Movie { MovieId = 14, Title = "The Dark Knight", Director = "Christopher Nolan", ReleaseDate = new DateTime(2008, 7, 18), Genre = "Action", Rating = 9.0m },
    new Movie { MovieId = 15, Title = "Spirited Away", Director = "Hayao Miyazaki", ReleaseDate = new DateTime(2001, 7, 20), Genre = "Animation", Rating = 8.6m });
        }
    }
}
