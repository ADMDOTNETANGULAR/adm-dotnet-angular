using OnlineShopping.UserService.Entities;
using OnlineShopping.UserService.Models;
using OnlineShopping.UserService.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HandsOnAPIUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private readonly IConfiguration configuration;
        public UserController(IUserRepository userRepository, IConfiguration configuration)
        {
            this.userRepository = userRepository;
            this.configuration = configuration;
        }
        // End Points
        [HttpPost("Register")]
        [AllowAnonymous] // Allow anonymous access to the Register endpoint
        public async Task<IActionResult> Register([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User cannot be null");
            }
            await userRepository.Register(user);
            return Ok(user);
        }
        [HttpPost("Login")]
        [AllowAnonymous] // Allow anonymous access to the Login endpoint
        public async Task<IActionResult> Login([FromBody] LoginDTO login)
        {
            if (login == null || string.IsNullOrEmpty(login.Email) || string.IsNullOrEmpty(login.Password))
            {
                return BadRequest("Email and Password are required");
            }
            var validatedUser = await userRepository.Validate(login.Email, login.Password);
            if (validatedUser == null)
            {
                return NotFound("Invalid User");
            }
            else
            {
                // Here you can generate a JWT token and return it in the response
                var response = new UserResponseDTO()
                {
                    UserId = validatedUser.UserId,
                    Role = validatedUser.Role,
                    Token = GetToken(validatedUser) // Replace with actual JWT token generation logic
                };
                return Ok(response);
            }

        }
        private string GetToken(User? user)
        {
            var issuer = configuration["Jwt:Issuer"];
            var audience = configuration["Jwt:Audience"];
            var key = Encoding.UTF8.GetBytes(configuration["Jwt:Key"]);
            //header part
            // // Create a signing key using the symmetric security key
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256
            );
            //payload part
            // Create claims for the user
            var claims = new[]
            {
                        new Claim(ClaimTypes.Name,user.UserName),
                        new Claim(ClaimTypes.Role, user.Role),
                    };
            // Set the expiration time for the token
            var expires = DateTime.UtcNow.AddMinutes(10);
            //signature part
            // Create the JWT token
            var token = new JwtSecurityToken(
        issuer: issuer,
        audience: audience,
        claims: claims,
        expires: expires,
        signingCredentials: signingCredentials
    );
            // Serialize the token to a string
            var tokenStr = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenStr;
        }

    }
}
