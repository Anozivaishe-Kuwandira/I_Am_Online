using Microsoft.AspNetCore.Mvc;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using api.Models;
using System.Text.Json;
using System.IO;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost("register")]
        public IActionResult Register(Staff model)
        {
            // Save user to database
            // Hash password before saving
            // Return success response

            return Ok("User registered successfully!");
        }

        [HttpPost("login")]
        public IActionResult Login(LoginModel login)
        {
            // Validate user credentials (for example, compare with database)
            if (login.Username == "admin" && login.Password == "admin")
            {
                // Generate JWT token
                var token = GenerateJwtToken(login.Username);

                // Return token and user information
                return Ok(new { token });
            }
            else
            {
                return Unauthorized("Invalid username or password");
            }
        }

        private string GenerateJwtToken(string username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, username),
                // Add more claims as needed
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

public class LoginModel
{
    public string? Username { get; set; } = "";
    public string? Password { get; set; } = "";
}
