using Microsoft.EntityFrameworkCore;
namespace HandsOnFileUploadtoBlobStorage_Demo1.Models
{
    public class ImageDbContext:DbContext
    {
        public DbSet<Image> Images { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=ImageDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
    }
}
