namespace HandsOnFileUploadtoBlobStorage_Demo1.Models
{
    public class BlobResponseDto
    {
        public string? Status { get; set; }
        public bool Error { get;set; }
        public Blobdto Blob { get; set; }
        public BlobResponseDto()
        {
            Blob = new Blobdto();
        }

    }
}
