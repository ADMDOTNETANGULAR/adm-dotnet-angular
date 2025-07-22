using Microsoft.EntityFrameworkCore;
using OnlineShopping.OrderService.DBContext;
using OnlineShopping.OrderService.Entities;

namespace OnlineShopping.OrderService.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDBContext _context;
        public OrderRepository(OrderDBContext context)
        {
            _context = context;
        }
        public async Task AddOrderAsync(Order order)
        {
           _context.Orders.Add(order);
              await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int id)
        {
           var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"Order with ID {id} not found.");
            }
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
          
            return await _context.Orders.ToListAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
           return await _context.Orders.FindAsync(id);
        }

        public async Task UpdateOrderAsync(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }
    }
}
