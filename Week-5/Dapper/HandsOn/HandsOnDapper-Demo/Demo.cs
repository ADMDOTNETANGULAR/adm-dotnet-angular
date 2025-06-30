using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using HandsOnEFCodeFirst_Demo2.Entities;

namespace HandsOnDapper_Demo
{
    //Dapper with Parameters
    internal class Demo
    {
        string connectionString = "Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=MovieDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        IDbConnection db;
        public Demo()
        {
            db = new SqlConnection(connectionString);
        }
        //Dapper Dynamic Parameters
        public async Task<IEnumerable<dynamic>> GetMoviesByGenreAsync(string genre)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Genre", genre);
            return await db.QueryAsync("Select * from Movies where Genre = @Genre", parameters);
        }
        //Dapper Query with multile Parameters
        public async Task<IEnumerable<dynamic>> GetMoviesByDirectorAndRatingAsync(string director, decimal rating)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Director", director);
            parameters.Add("@Rating", rating);
            return await db.QueryAsync("Select * from Movies where Director = @Director and Rating >= @Rating", parameters);
        }
        //Dapper with string parameters
        public async Task<IEnumerable<dynamic>> GetMoviesByTitleAsync(string title)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Title", title);
            return await db.QueryAsync("Select * from Movies where Title like '%' + @Title + '%'", parameters);
        }
        //Dapper where in parameters
        public async Task<IEnumerable<Movie>> GetMoviesByIdsAsync()
        {
           List<int> movieIds =new List<int> { 1, 2, 3 }; // Example list of movie IDs
            string sql = "SELECT * FROM Movies WHERE MovieId IN @MovieId";
            return await db.QueryAsync<Movie>(sql, new { MovieId=movieIds});
        }

    }
}
