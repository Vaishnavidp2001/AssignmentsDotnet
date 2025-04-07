using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ArtExhibitionSystem.Application.Exceptions;
using ArtExhibitionSystem.Application.Interfaces.Identity;
using ArtExhibitionSystem.Application.Models;
using ArtExhibitionSystem.Application.Models.Identity;
using ArtExhibitionSystem.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace ArtExhibitionSystem.Identity.Services
{
    public class AuthService : IAuthService
    {
        readonly UserManager<ApplicationUser> _userManager;
        readonly SignInManager<ApplicationUser> _signInManger;
        readonly JwtSettings _jwtSettings;

        public AuthService(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,IOptions<JwtSettings>jwtsettings)
        {
            _userManager = userManager;
            _signInManger = signInManager;
            _jwtSettings= jwtsettings.Value;

        }
        public async Task<AuthResponse> Login(AuthRequest authRequest)
        {
             var user= await _userManager.FindByEmailAsync(authRequest.Email);
            if (user == null) 
            { 
                throw new NotFoundException($"user with email {authRequest.Email} not exist");
            }
            var userPassword =await  _signInManger.CheckPasswordSignInAsync(user, authRequest.Password, false);

            JwtSecurityToken jwtSecurityToken =await  GenerateToken(user);
            var response = new AuthResponse
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken)
            };
            return response;
        }

        private async Task< JwtSecurityToken> GenerateToken(ApplicationUser user)
        {
           var userClaims= await _userManager.GetClaimsAsync(user);

            var roles =await  _userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(roles => new Claim(ClaimTypes.Role, roles)).ToList();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim (JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim("uid",user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);
            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("asdfghdsdfgfdsdfggfghgfdsdfghgfdfghgfdfg                                                            "));
            var signingCredentials=new SigningCredentials(symmetricSecurityKey,SecurityAlgorithms.HmacSha256);
            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
             
        }

        public async Task<RegistrationResponse> Register(RegistrationRequest registrationRequest)
        {
            var user = new ApplicationUser()
            {
                Email = registrationRequest.Email,
                FirstName = registrationRequest.FirstName,
                LastName = registrationRequest.LastName,
                UserName = registrationRequest.UserName,
                EmailConfirmed = true

            };
           var result= await _userManager.CreateAsync(user, registrationRequest.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");               
                return new RegistrationResponse() { UserId = user.Id };
            }
            else
            {
                var errorResult=result.Errors.Select(e => e.Description.ToList());
                throw new BadRequestException($"{errorResult}");
            }
        }

        
    }
}
