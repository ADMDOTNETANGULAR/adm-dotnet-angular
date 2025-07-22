namespace OnlineShopping.OrderService.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Entities.Order>> GetAllOrdersAsync();
        Task<Entities.Order> GetOrderByIdAsync(int id);
        Task AddOrderAsync(Entities.Order order);
        Task UpdateOrderAsync(Entities.Order order);
        Task DeleteOrderAsync(int id);
    }
}
