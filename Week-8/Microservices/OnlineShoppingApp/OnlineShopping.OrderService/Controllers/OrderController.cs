using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.OrderService.Entities;
using OnlineShopping.OrderService.Repositories;

namespace OnlineShopping.OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        [HttpGet("GetAllOrders")]
        [Authorize(Roles = "Admin")] // This will allow both Admin and User roles to access this endpoint
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _orderRepository.GetAllOrdersAsync();
            return Ok(orders);
        }
        [HttpGet("GetOrderById/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var order = await _orderRepository.GetOrderByIdAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }
        [HttpPost("AddOrder")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> AddOrder([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest("Order cannot be null");
            }
            await _orderRepository.AddOrderAsync(order);
            return CreatedAtAction(nameof(GetOrderById), new { id = order.OrderId }, order);
        }
        [HttpPut("UpdateOrder")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateOrder([FromBody] Order order)
        {
            if (order == null)
            {
                return BadRequest("Order cannot be null");
            }
            await _orderRepository.UpdateOrderAsync(order);
            return NoContent();
        }
        [HttpDelete("DeleteOrder/{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            try
            {
                await _orderRepository.DeleteOrderAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
