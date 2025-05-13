using JWT.Authentication.Data;
using JWT.Authentication.Interfaces;
using JWT.Authentication.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT.Authentication.Services
{
    public class AuthServices : IAuthServices
    {
        private readonly JwtContext _context;
        private readonly IConfiguration _configuration;

        public AuthServices(JwtContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public Role AddRole(Role role)
        {
            var role1 = _context.Roles.Add(role);
            _context.SaveChanges();
            return role1.Entity;
        }

        public User AddUser(User user)
        {
            var user1 = _context.Users.Add(user);
            _context.SaveChanges();
            return user1.Entity;

        }

        public bool AssignRoleToUser(AddUserRole addUserRole)
        {
            try
            {
                var addRoles = new List<UserRole>();
                var user = _context.Roles.FirstOrDefault(s => s.RoleId == addUserRole.UserId);
                if (user == null)
                {
                    throw new Exception("User Not Valid");
                    //return false;
                }
                foreach (int role in addUserRole.RoleIds)
                {
                    var userRole = new UserRole();
                    userRole.RoleId = role;
                    userRole.UserId = user.RoleId;
                    addRoles.Add(userRole);
                }
                _context.UserRoles.AddRange(addRoles);
                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        public string LogIn(LogInRequest logInRequest)
        {
            if (logInRequest.UserName != null && logInRequest.Password != null)
               
            {
                    var user = _context.Users.SingleOrDefault(s => s.UserName == logInRequest.UserName && s.Password == logInRequest.Password);
                if (user != null)
                    {
                        var claims = new List<Claim>
                    {
                      new Claim(JwtRegisteredClaimNames.Sub , _configuration["jwt:Subject"]),
                      new Claim("Id",user.UserId.ToString()),
                      new Claim("UserName",user.Name)

                    };
                    var userRoles = _context.UserRoles.Where(u => u.UserId == user.UserId).ToList();
                    var roleIds = userRoles.Select(s => s.RoleId).ToList();
                    var roles = _context.Roles.Where(r => roleIds.Contains(r.RoleId)).ToList();

                    foreach(var role in roles)
                    {
                        claims.Add(new Claim("Role", role.Name));
                    }

                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:key"]));
                    var SignIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        _configuration["jwt:Issuer"],
                        _configuration["jwt:Audience"],
                        claims,
                        expires: DateTime.UtcNow.AddMinutes(10),
                        signingCredentials: SignIn);

                    var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return jwtToken;
                }
                else
                {
                    throw new Exception("User Is  Not valid");
                }
            }
            else
            {
                throw new Exception("Credentials is not valid");
            }
        }
    }
}
