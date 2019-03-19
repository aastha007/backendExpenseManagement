using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Controllers
{
    [Route("api/income")]
    [ApiController]
    public class IncomeController:ControllerBase
    {
        private readonly IIncomeRepository<Income> _dataRepository;
        
        public IncomeController(IIncomeRepository<Income> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        //GET:api/Income
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Income> Income = _dataRepository.GetAll();
            return Ok(Income);
        }


        //POST: api/Income
        [HttpPost]
        public IActionResult Post([FromBody] Income Income)
        {
            if (Income == null)
            {
                return BadRequest("Income Not Registered!");

            }
            var count = _dataRepository.GetAll().Count() + 1;
            //Income.TotalAmount = _dataRepository.Sum(count);
            _dataRepository.Add(Income);
            return Ok(Income);

        }



        //POST:api/Income/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Income Income)
        {
            if (Income == null)
            {
                return BadRequest("Income not registered");

            }
            Income IncomeToUpdate = _dataRepository.GetByPrimaryKey(id);
            if (IncomeToUpdate == null)
            {
                return NotFound("Entry Not Found");
            }
            _dataRepository.Update(IncomeToUpdate, Income);
            return NoContent();
        }
        //DELETE :api/Income/ 5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Income Income = _dataRepository.GetByPrimaryKey(id);
            if (Income == null)
            {
                return NotFound("The Income doesnot exist.");
            }
            _dataRepository.Delete(Income);
            return NoContent();
        }


    }
}
