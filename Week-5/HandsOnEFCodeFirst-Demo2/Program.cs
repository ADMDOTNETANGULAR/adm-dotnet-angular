using HandsOnEFCodeFirst_Demo2.Entities;
using Microsoft.EntityFrameworkCore;
using HandsOnEFCodeFirst_Demo2.Repositories;
namespace HandsOnEFCodeFirst_Demo2
{
    internal class Program
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
                Console.WriteLine("6.Get Movies By Genre");
                Console.WriteLine("7.Get Movies By Director");
                Console.WriteLine("8.Get Movies By Rating");
                Console.WriteLine("9.Get Movies By Release Date");
                Console.WriteLine("10.Get Movie By Name");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
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
                        {   Console.Write("Enter Movie Id: ");
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
                    case 6:
                        {
                            Console.Write("Enter Genre: ");
                            string genre = Console.ReadLine();
                            var moviesByGenre = movieContract.GetMoviesByGenreAsync(genre);
                            foreach (var movie in moviesByGenre.Result)
                            {
                                Console.WriteLine($"Id: {movie.MovieId}, Title: {movie.Title}, Director: {movie.Director}, Release Date: {movie.ReleaseDate?.ToShortDateString()}, Genre: {movie.Genre}, Rating: {movie.Rating}");
                            }
                        }
                        break;
                    case 7:
                        {
                            Console.Write("Enter Director: ");
                            string director = Console.ReadLine();
                            var moviesByDirector = movieContract.GetMoviesByDirectorAsync(director);
                            foreach (var movie in moviesByDirector.Result)
                            {
                                Console.WriteLine($"Id: {movie.MovieId}, Title: {movie.Title}, Director: {movie.Director}, Release Date: {movie.ReleaseDate?.ToShortDateString()}, Genre: {movie.Genre}, Rating: {movie.Rating}");
                            }
                        }
                        break;
                        case 8:
                        {
                            Console.Write("Enter Rating: ");
                            decimal rating = Convert.ToDecimal(Console.ReadLine());
                            var moviesByRating = movieContract.GetMoviesByRatingAsync(rating);
                            foreach (var movie in moviesByRating.Result)
                            {
                                Console.WriteLine($"Id: {movie.MovieId}, Title: {movie.Title}, Director: {movie.Director}, Release Date: {movie.ReleaseDate?.ToShortDateString()}, Genre: {movie.Genre}, Rating: {movie.Rating}");
                            }
                        }
                        break;
                        case 9:
                        {
                            Console.Write("Enter Release Date Year ");
                            int releaseYear = int.Parse(Console.ReadLine());
                            var moviesByReleaseDate = movieContract.GetMoviesByReleaseDateAsync(releaseYear);
                            foreach (var movie in moviesByReleaseDate.Result)
                            {
                                Console.WriteLine($"Id: {movie.MovieId}, Title: {movie.Title}, Director: {movie.Director}, Release Date: {movie.ReleaseDate?.ToShortDateString()}, Genre: {movie.Genre}, Rating: {movie.Rating}");
                            }
                        }
                        break;
                }

            } while (true);
        }
    }
}
