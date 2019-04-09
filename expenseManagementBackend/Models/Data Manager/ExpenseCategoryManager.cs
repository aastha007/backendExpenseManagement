using expenseManagementBackend.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models.Data_Manager
{
    public class ExpenseCategoryManager:IDataRepository<ExpenseCategory>
    {

        readonly dbContext _ExpenseCategoryContext;
        public ExpenseCategoryManager(dbContext context)
        {
            _ExpenseCategoryContext = context;
        }
        public IEnumerable<ExpenseCategory> GetAll()
        {
            return _ExpenseCategoryContext.ExpenseCategory.ToList();
        }

        public ExpenseCategory GetByPrimaryKey(int id)
        {
            return _ExpenseCategoryContext.ExpenseCategory.FirstOrDefault((e) => e.EC_Id == id);
        }
        public IEnumerable<ExpenseCategory> GetByForeignKey(string id)
        {
            return _ExpenseCategoryContext.ExpenseCategory.Where((e) => e.User_Id == id).ToList();

        }
        public void Add(ExpenseCategory Entity)
        {
            _ExpenseCategoryContext.ExpenseCategory.Add(Entity);
            _ExpenseCategoryContext.SaveChanges();

        }
        public void Update(ExpenseCategory ExpenseCategory, ExpenseCategory entity)
        {
            ExpenseCategory.Date = entity.Date;
            ExpenseCategory.Description = entity.Description;
            ExpenseCategory.Amount = entity.Amount;
            ExpenseCategory.Expense_Category = entity.Expense_Category;
             

            _ExpenseCategoryContext.SaveChanges();
        }
        public void Delete(ExpenseCategory ExpenseCategory)
        {
            _ExpenseCategoryContext.ExpenseCategory.Remove(ExpenseCategory);
            _ExpenseCategoryContext.SaveChanges();
        }
        
    }
}
