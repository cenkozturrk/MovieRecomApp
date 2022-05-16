using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRecom.Entity.Models;
using MovieRecomApp.Core.JWToken;
using System.Security.Cryptography;

namespace MovieRecomApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public static User user = new User();
        private readonly AuthFunction _function;
      
        

        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            user.UserName = request.UserName;   
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            return Ok(new AuthResponse { Status = true, Message = "User created successfully!" });
            
        }

        [HttpPost("{login}")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            if (user.UserName ==request.UserName)
            {
                return BadRequest(new AuthResponse { Status = false, Message = "User could not login!" });
            }

            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt ))
            {
                return BadRequest(new AuthResponse { Status = false, Message = "User could not login!" });
            }


            string token = CreateToken(user);
            return Ok(token);
        }

        
    }
}
