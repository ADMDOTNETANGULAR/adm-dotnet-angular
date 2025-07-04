namespace HandsOnMVCUsingModels.Dtos
{
    public class OrderBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string OrderId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
