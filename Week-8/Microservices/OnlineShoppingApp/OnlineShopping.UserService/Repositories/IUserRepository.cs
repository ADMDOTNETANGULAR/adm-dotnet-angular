using OnlineShopping.UserService.Entities;

namespace OnlineShopping.UserService.Repositories
{
    public interface IUserRepository
    {
        Task Register(User user);
        Task<User> Validate(string email,string pwd);
    }
}
