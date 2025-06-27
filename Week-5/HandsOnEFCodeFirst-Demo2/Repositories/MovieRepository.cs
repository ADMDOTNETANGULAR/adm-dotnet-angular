using HandsOnEFCodeFirst_Demo2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HandsOnEFCodeFirst_Demo2.Repositories
{
    internal class MovieRepository : IMovieContract
    {
        private readonly MovieDBContext _context;
        public MovieRepository()
        {
            _context = new MovieDBContext();
        }
        public async Task AddMovieAsync(Movie movie)
        {
           _context.Movies.Add(movie); // Add the movie to the context
               await _context.SaveChangesAsync(); // Save changes to the database
        }

        public async Task DeleteMovieAsync(int movieId)
        {
           var movie = _context.Movies.Find(movieId); // Find the movie by ID
            if (movie != null)
            {
                _context.Movies.Remove(movie); // Remove the movie from the context
                await _context.SaveChangesAsync(); // Save changes to the database
            }
            throw new KeyNotFoundException("Movie not found");
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _context.Movies.ToListAsync(); // Retrieve all movies from the database
        }

        public async Task<Movie?> GetMovieByIdAsync(int movieId)
        {
           return await _context.Movies.FindAsync(movieId); // Find a movie by its ID
        }

        public async Task<Movie?> GetMovieByNameAsync(string movieName)
        {
            return await _context.Movies
                .Where(m => m.Title.Equals(movieName, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefaultAsync(); // Find a movie by its name
        }

        public async Task<List<Movie>> GetMoviesByDirectorAsync(string director)
        {
           return await _context.Movies
                .Where(m => m.Director.Equals(director))
                .ToListAsync(); // Get movies by director
        }

        public async Task<List<Movie>> GetMoviesByGenreAsync(string genre)
        {
          return await _context.Movies
                .Where(m => m.Genre != null && m.Genre.Equals(genre))
                .ToListAsync(); // Get movies by genre
        }

        public async Task<List<Movie>> GetMoviesByRatingAsync(decimal rating)
        {
            return await _context.Movies
                .Where(m => m.Rating.HasValue && m.Rating.Value >= rating)
                .ToListAsync(); // Get movies by rating
        }

        public async Task<List<Movie>> GetMoviesByReleaseDateAsync(int year)
        {
            return await _context.Movies
                .Where(m => m.ReleaseDate.HasValue && m.ReleaseDate.Value.Year == year)
                .ToListAsync(); // Get movies by release date
        }

        public async Task UpdateMovieAsync(Movie movie)
        {
            _context.Movies.Update(movie); // Update the movie in the context
            await _context.SaveChangesAsync(); // Save changes to the database
        }
    }
}
