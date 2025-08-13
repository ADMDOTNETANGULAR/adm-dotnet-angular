namespace HandsOnFileUploadtoBlobStorage_Demo1.Models
{
    public class ImageService
    {
        private readonly ImageDbContext imageDbContext;
        public ImageService()
        {
            imageDbContext = new ImageDbContext();
        }
        public void AddImageUrl(Image image)
        {
            imageDbContext.Images.Add(image);
            imageDbContext.SaveChanges();
        }
        public List<Image> GetImageUrls()
        {
            return imageDbContext.Images.ToList();
        }
    }
}
