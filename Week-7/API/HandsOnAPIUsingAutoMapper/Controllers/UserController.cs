using AutoMapper;
using HandsOnAPIUsingAutoMapper.Models;
using HandsOnAPIUsingAutoMapper.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingAutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            // Populate the user details from DB
            //var user = GetUserDetails();

            //UserDto userDto = _mapper.Map<UserDto>(user);

            //return Ok(userDto);
            var user= new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@gmail.com",
                Address = new Address()
                {
                    Country = "US"
                }
            };
            var userDTO=_mapper.Map<UserDto>(user); //convert user data to userDto
            //var userDTO = new UserDto()
            //{
            //    FullName = user.FirstName + " " + user.LastName,
            //    Email = user.Email,
            //    AddressCountry = user.Address.Country
            //};
            return Ok(userDTO);
        }

        private static User GetUserDetails()
        {
            return new User()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Smith",
                Email = "John.Smith@gmail.com",
                Address = new Address()
                {
                    Country = "US"
                }
            };
        }
    }
}