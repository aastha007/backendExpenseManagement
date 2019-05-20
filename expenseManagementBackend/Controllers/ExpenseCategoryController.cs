using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Controllers
{

    [Route("api/expensecategory")]
    [ApiController]
    public class ExpenseCategoryController : ControllerBase
    {
        private readonly IDataRepository<ExpenseCategory> _dataRepository;

        public ExpenseCategoryController(IDataRepository<ExpenseCategory> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        //GET: api/ExpenseCategory
        [HttpGet("{from}/{to}")]
        public IActionResult Get([FromRoute] string from, string to)
        {
            IEnumerable<ExpenseCategory> ExpenseCategory = _dataRepository.GetAll();

            IEnumerable<ExpenseCategory> res =  ExpenseCategory.Where((e) =>  Convert.ToDateTime(e.Date) > Convert.ToDateTime(from) && Convert.ToDateTime(e.Date) < Convert.ToDateTime(to));

            return Ok(res);
        }

        //Get:api/expensecategory/5
        [HttpGet("{id}")]
        public IActionResult GetExpense([FromRoute] string id)
        {
            IEnumerable<ExpenseCategory> ExpenseCategory = _dataRepository.GetAll();
            var foundExpense = ExpenseCategory.Where(e => e.User_Id == id);

            if (foundExpense == null)
            {
                return BadRequest();
            }

            var sumofexpense = foundExpense.Sum((e) => e.Amount);

            return Ok(sumofexpense);

        }


        //POST: api/ExpenseCategory
        [HttpPost]
        public IActionResult Post([FromBody] ExpenseCategory ExpenseCategory)
        {
            if (ExpenseCategory == null)
            {
                return BadRequest("ExpenseCategory Not Registered!");

            }
            _dataRepository.Add(ExpenseCategory);
            return Ok(ExpenseCategory);

        }
        //PUT :api/ExpenseCategory/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ExpenseCategory ExpenseCategory)
        {
            if (ExpenseCategory == null)
            {
                return BadRequest("Employee not registered");

            }
            ExpenseCategory ExpenseCategoryToUpdate = _dataRepository.GetByPrimaryKey(id);
            if (ExpenseCategoryToUpdate == null)
            {
                return NotFound("ExpenseCategory Not Found");
            }
            _dataRepository.Update(ExpenseCategoryToUpdate, ExpenseCategory);
            return NoContent();
        }
        //DELETE :api/ExpenseCategory/ 5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ExpenseCategory ExpenseCategory = _dataRepository.GetByPrimaryKey(id);
            if (ExpenseCategory == null)
            {
                return NotFound("The ExpenseCategory doesno exist.");
            }
            _dataRepository.Delete(ExpenseCategory);
            return NoContent();
        }

    }
}