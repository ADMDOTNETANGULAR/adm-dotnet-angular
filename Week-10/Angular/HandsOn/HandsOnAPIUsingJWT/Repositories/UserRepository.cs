using HandsOnAPIUsingJWT.DataContext;
using HandsOnAPIUsingJWT.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandsOnAPIUsingJWT.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly OnlineShopDBContext _context;

        public UserRepository(OnlineShopDBContext context)
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
           return await _context.Users.SingleOrDefaultAsync(u=>u.Email == email && u.Password == pwd);   
        }
    }
}
