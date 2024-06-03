using Microsoft.AspNetCore.Mvc;
using RoleBasedAccessManagement.Infrastructure.Repository;
using RoleBasedAccessManagement.Infrastructure.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace RoleBasedAccessManagement.Presentation.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserRepository _User;
        private IConfiguration _config;

        public AuthController(IConfiguration config)
        {
            //this._User = new UserRepository();
            _config = config;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var check = _User.GetSingleByEmail(user.Email);
            if (check.Password == user.Password)
            {
                var tokenstring = GenerateJSONWebToken(user);
                return Ok(new {token = tokenstring});
            }
            else
            {
                ViewBag.error = true;
                return View();
            }
        }


        //Method in order to generate json web token
        private string GenerateJSONWebToken(User _User)
        {
            var SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var Credentials = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, _User.Email),
                new Claim("uid", _User.UserId.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(_config["Jwt:DurationInMinutes"])),
                signingCredentials: Credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
