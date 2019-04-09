using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Repository;
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
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<ExpenseCategory> ExpenseCategory = _dataRepository.GetAll();
            return Ok(ExpenseCategory);
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

            return Ok(foundExpense);

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
            return CreatedAtRoute("Get", new { ExpenseCategory_Id = ExpenseCategory.EC_Id }, ExpenseCategory);

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