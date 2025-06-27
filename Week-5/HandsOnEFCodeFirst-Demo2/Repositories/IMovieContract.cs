using HandsOnEFCodeFirst_Demo2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEFCodeFirst_Demo2.Repositories
{
    internal interface IMovieContract
    {
        //Define the contract for movie repository operations
        Task<List<Movie>> GetAllMoviesAsync(); // Get all movies
        Task<Movie> GetMovieByIdAsync(int movieId); // Get a movie by its ID
        Task AddMovieAsync(Movie movie); // Add a new movie
        Task UpdateMovieAsync(Movie movie); // Update an existing movie
        Task DeleteMovieAsync(int movieId); // Delete a movie by its ID
        Task GetMovieByNameAsync(string movieName); // Get a movie by its name
        Task<List<Movie>> GetMoviesByGenreAsync(string genre); // Get movies by genre
        Task<List<Movie>> GetMoviesByDirectorAsync(string director); // Get movies by director
        Task<List<Movie>> GetMoviesByRatingAsync(decimal rating); // Get movies by rating
        Task<List<Movie>> GetMoviesByReleaseDate(int year); // Get movies by release date
    }
}
