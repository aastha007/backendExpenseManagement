using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController:ControllerBase
    {
        readonly UserManager<IdentityUser> _userManager;

        public UserController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        ////GET: api/User
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    //IEnumerable<user> user = .GetAll();
        //    //return Ok(user);
        //}

        ////POST: api/User
        //[HttpPost]
        //public IActionResult Post([FromBody] user user)
        //{
        //    if(user==null)
        //    {
        //        return BadRequest("User Not Registered!");

        //    }
        //    _dataRepository.Add(user);
        //    return CreatedAtRoute("Get", new { Id = user.User_Id }, user);

        //}
        //GET :api/user/5
        [HttpGet("{email}")]
        public async Task<IActionResult> Get(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user==null)
            {
                return BadRequest("Employee not registered");

            }

            return Ok(user);
        }
        ////DELETE :api/USER/ 5
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    user user = _dataRepository.GetByPrimaryKey(id);
        //    if(user==null)
        //    {
        //        return NotFound("The user does not exist.");
        //    }
        //    _dataRepository.Delete(user);
        //    return NoContent();
        //}
        
    }
}
