using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Repository;
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
        private readonly IDataRepository<user> _dataRepository;

        public UserController(IDataRepository<user> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        //GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<user> user = _dataRepository.GetAll();
            return Ok(user);
        }

        //POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] user user)
        {
            if(user==null)
            {
                return BadRequest("User Not Registered!");

            }
            _dataRepository.Add(user);
            return CreatedAtRoute("Get", new { Id = user.User_Id }, user);

        }
        //PUT :api/user/5
        [HttpPut("{id}")]
        public  IActionResult Put(int id, [FromBody] user user)
        {
            if(user==null)
            {
                return BadRequest("Employee not registered");

            }
            user userToUpdate = _dataRepository.GetByPrimaryKey(id);
            if(userToUpdate==null)
            {
                return NotFound("User Not Found");
            }
            _dataRepository.Update(userToUpdate, user);
            return NoContent();
        }
        //DELETE :api/USER/ 5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            user user = _dataRepository.GetByPrimaryKey(id);
            if(user==null)
            {
                return NotFound("The user does not exist.");
            }
            _dataRepository.Delete(user);
            return NoContent();
        }
        
    }
}
