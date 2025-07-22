using System.ComponentModel.DataAnnotations;
namespace OnlineShopping.UserService.Entities
{
    public class User
    {
        [Key]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
