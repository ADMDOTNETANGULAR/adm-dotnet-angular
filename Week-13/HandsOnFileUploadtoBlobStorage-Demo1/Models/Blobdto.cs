namespace HandsOnFileUploadtoBlobStorage_Demo1.Models
{
    public class Blobdto
    {
        public string? Uri { get; set; }
        public string? Name { get; set; }
        public string? ContentType { get; set; }
        public Stream? Content { get; set; }
    }
}
