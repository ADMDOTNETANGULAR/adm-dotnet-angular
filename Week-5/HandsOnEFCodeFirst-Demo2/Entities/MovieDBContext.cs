using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    internal class MovieDBContext:DbContext
    {
        //Define the DbSet for Movie entity
        public DbSet<Movie> Movies { get; set; }
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
        }
    }
}
