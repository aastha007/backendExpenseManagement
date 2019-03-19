using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Repository;
using Microsoft.AspNetCore.Mvc;

namespace expenseManagementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IDataRepository<user> _service;

        public ValuesController(IDataRepository<user> service)
        {
            _service = service;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var s = "value1";
            return Ok(s);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("value");
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
