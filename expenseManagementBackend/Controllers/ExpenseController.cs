using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Controllers
{
    [Route("api/expense")]
    [ApiController]
    public class ExpenseController: ControllerBase
    {
        
        private readonly IDataRepository<Expense> _dataRepository;

        public ExpenseController(IDataRepository<Expense> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        //GET:api/Expense
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Expense> Expense = _dataRepository.GetAll();
            return Ok(Expense);
        }
        //POST:api/Expense/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Expense Expense)
        {
            if (Expense == null)
            {
                return BadRequest("Expense not registered");

            }
            Expense ExpenseToUpdate = _dataRepository.GetByPrimaryKey(id);
            if (ExpenseToUpdate == null)
            {
                return NotFound("Entry Not Found");
            }
            _dataRepository.Update(ExpenseToUpdate, Expense);
            return NoContent();
        }
        //DELETE :api/Expense/ 5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Expense Expense = _dataRepository.GetByPrimaryKey(id);
            if (Expense == null)
            {
                return NotFound("The Expense doesnot exist.");
            }
            _dataRepository.Delete(Expense);
            return NoContent();
        }

    }
}
