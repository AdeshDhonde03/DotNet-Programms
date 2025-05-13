using JWT.Authentication.Interfaces;
using JWT.Authentication.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWT.Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthServices _services;

        public AuthController(IAuthServices services)
        {
            _services = services;
        }

        
        [HttpPost("logIn")]
        public ActionResult Login([FromBody] LogInRequest loginRequest)
        {
            var token = _services.LogIn(loginRequest);
            return Ok(token);
        }
       
        [HttpPost("addUser")]
        public ActionResult<User> AddUser([FromBody] User user)
        {
            var adduser = _services.AddUser(user);
            return Ok(adduser);
        }

        [HttpPost("addRole")]
       
        public ActionResult<Role> AddRole([FromBody] Role role) 
        {
            var addrole = _services.AddRole(role);
            return Ok(addrole);
        }

        [HttpPost("assignUserRole")]
        public ActionResult<AddUserRole> AddUserRole([FromBody] AddUserRole addUserRole)
        {
            var adduserrole = _services.AssignRoleToUser(addUserRole);
            return Ok(adduserrole);

        }

        //// GET api/<AuthController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        

      

        //// DELETE api/<AuthController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
