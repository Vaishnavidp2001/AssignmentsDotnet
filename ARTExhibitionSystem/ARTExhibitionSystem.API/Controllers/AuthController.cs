using ARTExhibition.Application.Interfaces;
using ARTExhibitionSystem.Identity.Services;
using Microsoft.AspNetCore.Mvc;
using ITokenService = ARTExhibition.Application.Interfaces.ITokenService;
using ARTExhibitionSystem.Domain.Entities;
using ARTExhibitionSystem.Identity.Model;
using Microsoft.AspNetCore.Identity;

namespace ARTExhibitionSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
         
        private readonly ITokenService _tokenService;
        private readonly UserManager<ApplicationUser> _userManager;

        // Updated constructor without IUserService
        public AuthController(UserManager<ApplicationUser> userManager, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _userManager = userManager;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            // Validate user credentials (Needs a proper implementation, if required)
            if (string.IsNullOrEmpty(request.Username) || string.IsNullOrEmpty(request.Password))
            {
                return BadRequest("Invalid credentials");
            }

            // Generate JWT token (Modify as per your authentication flow)
            var token = _tokenService.GenerateToken(request.Username, "UserRole"); // Replace "UserRole" with actual role retrieval logic
            return Ok(new { Token = token });
        }






        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
        {
            var user = new ApplicationUser
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.Username,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                return Ok(new RegistrationResponse { UserId = user.Id });
            }
            else
            {
                var errorResult = string.Join(", ", result.Errors.Select(e => e.Description));
                return BadRequest(new { Error = errorResult });
            }
        }
    }


    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }



    public class RegistrationRequest
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class RegistrationResponse
    {
        public string UserId { get; set; }
    }





}












