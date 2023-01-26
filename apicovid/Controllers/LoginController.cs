using apicovid.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace apicovid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;

        public LoginController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        public IActionResult Login(Person person)
        {
            var User = Authenticate(person);
            if (User != null)
            {
                //creamos el token
                var token = GenerateToken(User);
                return Ok(token);
            }
            else
            {
                return NotFound("Usuario no encontrado");
            }

        }

        private Person Authenticate(Person person)
        {
            using (ApirestpruebaContext db = new ApirestpruebaContext())
            {
                Person oPerson = db.People.FirstOrDefault(persona => persona.PersonUsername == person.PersonUsername);
                Rol oRol= db.Rols.Find(oPerson.RolId);
                return oPerson;
            }

        }

        private string GenerateToken(Person user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Crear los claims
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.PersonUsername),
                new Claim(ClaimTypes.Name, user.PersonName),
                new Claim(ClaimTypes.Role, user.Rol.RolName)

            };


            // Crear el token

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
