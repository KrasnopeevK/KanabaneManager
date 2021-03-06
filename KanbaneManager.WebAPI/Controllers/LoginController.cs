using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using KanbaneManager.Shared.Entities.AuthModels;
using KanbaneManager.DL.Repository;
using KanbaneManager.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace KanbaneManager.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private KanbaneContext _context;

        public LoginController(KanbaneContext context)
        {
            _context = context;
        }
        
        [HttpPost]
        public IActionResult Token(LoginRequest token)
        {
            var identity = GetIdentity(token.Login, token.Password);
            if (identity == null)
            {
                var badRequest = new UserManagerResponse
                {
                    Message = "Неверный логин или пароль",
                    IsSuccess = false
                };
                return Json(badRequest);
            }
 
            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
 
            var employee = _context.Set<Employee>().FirstOrDefault(x => x.Id == int.Parse(identity.Name));

            var umr = new UserManagerResponse
            {    
                UserInfo = new Dictionary<string, string>
                {
                    {"FirstName", employee?.FirstName},
                    {"LastName", employee?.LastName},
                    {ClaimTypes.NameIdentifier, employee?.Id.ToString()},
                    {ClaimTypes.Role, identity.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).FirstOrDefault()}
                },
                Message = encodedJwt,
                IsSuccess = true
            };
            
            return Json(umr);
        }
 
        private ClaimsIdentity GetIdentity(string username, string password)
        {
            var person = _context.Set<User>().Where(x => x.Login == username && x.Pwd == password).Include(x => x.Role).ToList().FirstOrDefault();
            
            if (person != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, person.EmployeeId.ToString()),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role.Name)
                };
                var claimsIdentity =
                new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType);
                return claimsIdentity;
            }
            return null;
        }
    }
}