namespace HandsOnAPIUsingExceptionHandling.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {
        }
        public NotFoundException() : base("The requested resource was not found.")
        {
        }
    }
}
