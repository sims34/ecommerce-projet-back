using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace E_commerceProject.Auth
{
    public class UserAuth
{

        private readonly IConfiguration _config;
        

        public UserAuth(IConfiguration config)
        {
            _config = config;
        }

        public Login Authenticate(Login login)
        {
            return new Login()
            {
              LoginId = Guid.NewGuid(),
              UserId  = Guid.NewGuid(),
              Password  = "sisisi",
              Username = "sims"
            };
        }
        public string BuildToken(Login login)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.FamilyName, login.Username),
                new Claim(JwtRegisteredClaimNames.Jti, login.UserId.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["jwt:Issuer"], _config["jwt:Issuer"],
                        claims,
                        expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

