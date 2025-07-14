using JobPortal.Domain;
using JobPortal.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
namespace JobPortal.Infrastructure.Repositories
{
    internal class UserRepository : IUserContract
    {
        private readonly JobPortalDbContext _context;
        public UserRepository()
        {
            _context = new JobPortalDbContext();
        }
        public async Task AddUserAsync(User user)
        {
           _context.Users.Add(user);
              await _context.SaveChangesAsync();
        }

        public async Task<User> AuthenticateUserAsync(string username, string password)
        {
           return await _context.Users
                .SingleOrDefaultAsync(u => u.UserName == username && u.Password == password);
        }

        public Task DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
