using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;

using Server.Persistence;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public ActionResult<IList<User>> GetUserList()
        {
            try
            {
                IList<User> userList = _userRepo.GetUsers();
                return Ok(userList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        [HttpPost]
        public ActionResult<User> RegisterUser([FromBody] User user)
        {
            try
            {
                _userRepo.RegisterUser(user);
            }
            catch (Exception e)
            {
                return BadRequest("User registration failed");
            }
            
            return Created("User with username: " + user.UserName, user);
        }
        
        
    }
}