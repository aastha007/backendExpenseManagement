using expenseManagementBackend.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models.Data_Manager
{
    public class ExpenseManager:IDataRepository<Expense>
    {
        readonly dbContext _ExpenseContext;
        public ExpenseManager(dbContext ExpenseContext)
        {
            _ExpenseContext = ExpenseContext;
        }
        public IEnumerable<Expense> GetAll()
        {
            return _ExpenseContext.Expense.ToList();
        }
        public Expense GetByPrimaryKey(int id)
        {
            return _ExpenseContext.Expense.FirstOrDefault(e => e.Expense_Id == id);

        }
        public IEnumerable<Expense> GetByForeignKey(string id)
        {
            return _ExpenseContext.Expense.Where((e) => e.User_Id == id).ToList();

        }

        public void Add(Expense Entity)
        {
            _ExpenseContext.Expense.Add(Entity);
            _ExpenseContext.SaveChanges();

        }
        public void Update(Expense Expense, Expense entity)
        {
          //  Expense.TotalAmount = entity.TotalAmount;
          

            _ExpenseContext.SaveChanges();
        }
        public void Delete(Expense Expense)
        {
            _ExpenseContext.Expense.Remove(Expense);
            _ExpenseContext.SaveChanges();
        }


    }
}
