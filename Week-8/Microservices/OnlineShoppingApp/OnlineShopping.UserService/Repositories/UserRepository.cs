using OnlineShopping.UserService.DataContext;
using OnlineShopping.UserService.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopping.UserService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDBContext _context;

        public UserRepository(UserDBContext context)
        {
            _context = context;
        }

        public async Task Register(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> Validate(string email, string pwd)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.Email == email && u.Password == pwd);
        }
    }
}
