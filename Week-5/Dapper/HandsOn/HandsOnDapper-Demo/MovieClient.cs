using HandsOnEFCodeFirst_Demo2.Entities;
using HandsOnEFCodeFirst_Demo2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDapper_Demo
{
    internal class MovieClient
    {
        static void Main(string[] args)
        {
            //Instantiate MovieRepository
            IMovieContract movieContract = new MovieRepository();
            do
            {
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Get All Movies");
                Console.WriteLine("3. Get Movie By Id");
                Console.WriteLine("4. Update Movie");
                Console.WriteLine("5. Delete Movie");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting the application...");
                        return; // Exit the application
                        break;
                    case 1:
                        {

                            var movie = new Movie { MovieId = 16, Title = "Inception-2", Director = "Christopher Nolan", ReleaseDate = new DateTime(2020, 7, 23), Genre = "Sci-Fi", Rating = 8.8m };
                            movieContract.AddMovieAsync(movie);
                        }
                        break;
                    case 2:
                        {
                            var movies = movieContract.GetAllMoviesAsync();
                            foreach (var movie in movies.Result)
                            {
                                Console.WriteLine($"Id: {movie.MovieId}, Title: {movie.Title}, Director: {movie.Director}, Release Date: {movie.ReleaseDate?.ToShortDateString()}, Genre: {movie.Genre}, Rating: {movie.Rating}");
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Enter Movie Id: ");
                            int movieId = Convert.ToInt32(Console.ReadLine());
                            var movie = movieContract.GetMovieByIdAsync(movieId);
                            if (movie.Result != null)
                            {
                                Console.WriteLine($"Id: {movie.Result.MovieId}, Title: {movie.Result.Title}, Director: {movie.Result.Director}, Release Date: {movie.Result.ReleaseDate?.ToShortDateString()}, Genre: {movie.Result.Genre}, Rating: {movie.Result.Rating}");
                            }
                            else
                            {
                                Console.WriteLine("Movie not found.");
                            }
                        }
                        break;
                    case 4:
                        {
                            Movie movie = new Movie();
                            Console.Write("Enter Movie Id to update: ");
                            movie.MovieId = Convert.ToInt32(Console.ReadLine());
                            var existingMovie = movieContract.GetMovieByIdAsync(movie.MovieId);
                            Console.Write("Enter Movie Title: ");
                            existingMovie.Result.Title = Console.ReadLine();
                            Console.Write("Enter Movie Director: ");
                            existingMovie.Result.Director = Console.ReadLine();
                            movieContract.UpdateMovieAsync(existingMovie.Result);


                        }
                        break;
                    case 5:
                        {
                            Console.Write("Enter Movie Id to delete: ");
                            int movieId = Convert.ToInt32(Console.ReadLine());
                            var existingMovie = movieContract.GetMovieByIdAsync(movieId);
                            if (existingMovie.Result != null)
                            {
                                movieContract.DeleteMovieAsync(existingMovie.Result.MovieId);
                                Console.WriteLine("Movie deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Movie not found.");
                            }
                        }
                        break;
                }

            } while (true);
        }
    }
}
