using expenseManagementBackend.Models;
using expenseManagementBackend.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeCategoryController : ControllerBase
    {
        private readonly IDataRepository<IncomeCategory> _dataRepository;

        public IncomeCategoryController(IDataRepository<IncomeCategory> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        //GET: api/IncomeCategory
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<IncomeCategory> IncomeCategory = _dataRepository.GetAll();
            return Ok(IncomeCategory);
        }
        //Get:api/incomecategory/5
        [HttpGet("{id}")]
      public IActionResult GetIncome([FromRoute] int id)
    {
            var Obj= _dataRepository.GetByForeignKey(id);
            return Ok(Obj);
    }
    
        //POST: api/IncomeCategory
        [HttpPost]
        public IActionResult Post([FromBody] IncomeCategory IncomeCategory)
        {
            if (IncomeCategory == null)
            {
                return BadRequest("IncomeCategory Not Registered!");

            }
            _dataRepository.Add(IncomeCategory);
            return CreatedAtRoute("Get", new { IncomeCategory_Id = IncomeCategory.IC_Id }, IncomeCategory);

        }
        //PUT :api/IncomeCategory/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] IncomeCategory IncomeCategory)
        {
            if (IncomeCategory == null)
            {
                return BadRequest("Employee not registered");

            }
            IncomeCategory IncomeCategoryToUpdate = _dataRepository.GetByPrimaryKey(id);
            if (IncomeCategoryToUpdate == null)
            {
                return NotFound("IncomeCategory Not Found");
            }
            _dataRepository.Update(IncomeCategoryToUpdate, IncomeCategory);
            return NoContent();
        }
        //DELETE :api/IncomeCategory/ 5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IncomeCategory IncomeCategory = _dataRepository.GetByPrimaryKey(id);
            if (IncomeCategory == null)
            {
                return NotFound("The IncomeCategory doesno exist.");
            }
            _dataRepository.Delete(IncomeCategory);
            return NoContent();
        }





    }
}
