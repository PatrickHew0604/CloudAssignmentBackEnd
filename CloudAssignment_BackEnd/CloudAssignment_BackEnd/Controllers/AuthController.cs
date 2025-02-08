using System.Runtime.CompilerServices;
using CloudAssignment_BackEnd.Models.DTO;
using CloudAssignment_BackEnd.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CloudAssignment_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }


        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerRequestDTO.Username,
                Email = registerRequestDTO.Email,
                PhoneNumber = registerRequestDTO.phoneNumber
            };

            var identityResult = await userManager.CreateAsync(identityUser,registerRequestDTO.Password);

            if(identityResult.Succeeded)
            {
                if(registerRequestDTO.Role != null)
                {
                    identityResult = await userManager.AddToRoleAsync(identityUser, registerRequestDTO.Role);
                
                
                    if(identityResult.Succeeded)
                    {
                        return Ok("User was registered !");
                    }
                    
                }
            }
            return BadRequest("Username Has Been Used");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            var user = await userManager.FindByEmailAsync(loginRequestDTO.Username);
            
            if(user != null)
            {
                var isPasswordCorrect = await userManager.CheckPasswordAsync(user, loginRequestDTO.Password);
                if (isPasswordCorrect)
                {
                    // Create Token
                    var role = await userManager.GetRolesAsync(user);

                    var token = tokenRepository.CreateJWTToken(user, role[0]);

                    var tokenResponse = new LoginResponseDTO
                    {
                        JwtToken = token
                    };

                    return Ok(tokenResponse);
                }
            }
            return BadRequest("User not found");
        }
    }
}
