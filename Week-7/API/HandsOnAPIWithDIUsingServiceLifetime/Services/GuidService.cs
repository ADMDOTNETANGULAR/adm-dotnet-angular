namespace HandsOnAPIWithDIUsingServiceLifetime.Services
{
    public class GuidService : IGuidService
    {
        private readonly Guid _guid;

        public GuidService()
        {
            _guid = Guid.NewGuid(); // Generate a random GUID at object creation
        }

        public Guid GetGuid() => _guid;
    }
}
