using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TrainingCenterCRM.BLL.Interfaces;
using TrainingCenterCRM.Core.Models;

namespace TrainingCenterCRM.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public UserService(UserManager<User> userManager,
                           RoleManager<IdentityRole> roleManager,
                           IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        public async Task AddUser(string email, string password, string role)
        {
            var user = new User { Email = email, UserName = email };
            var result = await _userManager.CreateAsync(user, password);
            if (!result.Succeeded)
            {
                throw new Exception(string.Join(",", result.Errors.Select(er => er.Description).ToList()));
            }

            if (await _roleManager.RoleExistsAsync(role))
                await _userManager.AddToRoleAsync(user, role);
        }

        public async Task<bool> CheckPassword(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user != null && await _userManager.CheckPasswordAsync(user, password);
        }

        public async Task<string> GetUserIdByEmail(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return user.Id;
        }

        public async Task<string> GetToken(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            
            if (user == null)
                throw new ArgumentException("Incorrect email");

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["TokkenOption:SecretKey"]));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, email)
            };

            var userRoles = await _userManager.GetRolesAsync(user);
            foreach (var userRole in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            var tokenOptions = new JwtSecurityToken(
                issuer: _configuration["TokkenOption:Issuer"],
                audience: _configuration["TokkenOption:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: signingCredentials
            );
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return token;
        }
        public async Task<List<string>> GetUserRoles(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            var userRoles = await _userManager.GetRolesAsync(user);
            return userRoles.ToList();
        }
    }
}
