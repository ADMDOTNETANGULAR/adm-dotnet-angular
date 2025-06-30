using HandsOnEFCodeFirst_Demo2.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace HandsOnEFCodeFirst_Demo2.Repositories
{
    internal class MovieRepository : IMovieContract
    {
        string connectionString = "Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=MovieDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        IDbConnection db;
        public MovieRepository()
        {
            db = new SqlConnection(connectionString);
        }
        public async Task AddMovieAsync(Movie movie)
        {
            string qry = "Insert into Movies(MovieId,Title,Director,ReleaseDate,Genre,Rating) values(@MovieId,@title,@Director,@ReleaseDate,@Genre,@Rating)";
            await db.ExecuteAsync(qry, movie);
        }

        public async Task DeleteMovieAsync(int movieId)
        {
            string qry = "Delete From Movies where MovieId=@MovieId";
            await db.ExecuteAsync(qry, movieId);
        }

        public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
        {
            return await db.QueryAsync<Movie>("Select * from Movies"); // Retrieve all movies from the database
        }

        public async Task<Movie?> GetMovieByIdAsync(int movieId)
        {
            return await db.QuerySingleOrDefaultAsync<Movie>("Select * from Movies where MoveId=@MovieId", movieId); // Find a movie by its ID
        }
  
        public async Task UpdateMovieAsync(Movie movie)
        {
           await db.ExecuteAsync("Update Movies set Title=@Title,Director=@Director,ReleaseDate=@ReleaseDate,Genre=@Genre,Rating=@Rating where MovieId=@MovieId", movie); // Update an existing movie
        }
    }
}
