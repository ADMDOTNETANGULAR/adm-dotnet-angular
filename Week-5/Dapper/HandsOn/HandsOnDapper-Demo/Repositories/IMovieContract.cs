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
        Task<IEnumerable<Movie>> GetAllMoviesAsync(); // Get all movies
        Task<Movie?> GetMovieByIdAsync(int movieId); // Get a movie by its ID
        Task AddMovieAsync(Movie movie); // Add a new movie
        Task UpdateMovieAsync(Movie movie); // Update an existing movie
        Task DeleteMovieAsync(int movieId); // Delete a movie by its ID
      
    }
}
