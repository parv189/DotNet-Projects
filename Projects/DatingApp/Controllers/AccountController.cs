using DatingApp.DTOs;
using DatingApp.Interfaces;
using DatingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly DatingAppContext _dbcontext;
        private readonly ITokenService _tokenService;
        public AccountController(DatingAppContext dbcontext,ITokenService tokenService)
        {
            _tokenService= tokenService;
            _dbcontext = dbcontext;
        }

        [HttpPost("register")]

        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            if (await UserExists(registerDto.Email))
                return BadRequest("User Exist with this Email Id");
            
            using var hmac = new HMACSHA256();

            var user = new AppUser
            {
                UserName = registerDto.Username,
                Email = registerDto.Email,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt = hmac.Key
            };

            _dbcontext.Users.Add(user);
            await _dbcontext.SaveChangesAsync();

            return Ok(user);
        }

        private async Task<bool> UserExists(string email)
        {
            return await _dbcontext.Users.AnyAsync(x=> x.Email == email.ToLower());
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var user = await _dbcontext.Users.FirstOrDefaultAsync(x=> x.Email == loginDto.Email);
            if(user == null) return Unauthorized("Invalid Email");

            using var hmac = new HMACSHA256(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));
            
            for(int i=0;i<computedHash.Length;i++)
            {
                if (computedHash[i] != user.PasswordHash[i])
                {
                    return Unauthorized("Invalid Password");
                }
            }
            return Ok(new UserDto
            {
                UserName = user.UserName,
                Email = user.Email,
                Token = _tokenService.CreateToken(user)
            });
        }
    }
}
