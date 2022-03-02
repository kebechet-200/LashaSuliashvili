using EstateManagement.Services.Models.JWTConfiguration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Practice_1.Services.Abstractions;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System;

namespace EstateManagement.Services.Implementations
{
    public class JWTService : IJWTService
    {
        private readonly string _secret;
        private readonly int _expDateInMin;

        public JWTService(IOptions<JWTConfiguration> options)
        {
            _secret = options.Value.Secret;
            _expDateInMin = options.Value.ExpirationInMinutes;
        }
        public string GenerateSecurityToken(string Username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_secret);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, Username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(_expDateInMin),
                Audience = "localhost",
                Issuer = "localhost",
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
