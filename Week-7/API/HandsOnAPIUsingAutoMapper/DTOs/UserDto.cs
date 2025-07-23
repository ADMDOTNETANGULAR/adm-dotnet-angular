using System.ComponentModel.DataAnnotations;

namespace HandsOnAPIUsingAutoMapper.DTOs
{
    public class UserDto
    {
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Country")]
        public string AddressCountry { get; set; }

        public string Email { get; set; }
    }
}
