using HandsOnAPIUsingJWT.Entities;

namespace HandsOnAPIUsingJWT.Repositories
{
    public interface IUserRepository
    {
        Task Register(User user);
        Task<User> Validate(string email,string pwd);
    }
}
