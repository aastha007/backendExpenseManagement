using expenseManagementBackend.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models.Data_Manager
{
    public class IncomeManager:IIncomeRepository<Income>
    {
        readonly dbContext _IncomeContext;
        public IncomeManager(dbContext IncomeContext)
        {
            _IncomeContext = IncomeContext;
        }
        public IEnumerable<Income> GetAll()
        {
            return _IncomeContext.Income.ToList();
        }
        public Income GetByPrimaryKey(int id)
        {
            return _IncomeContext.Income.FirstOrDefault(e => e.Income_Id == id);

        }

        public IEnumerable<Income> GetByForeignKey(int id)
        {
            return _IncomeContext.Income.Where((e) => e.User_Id == id).ToList();

        }
        public void Add(Income Entity)
        {
            _IncomeContext.Income.Add(Entity);
            _IncomeContext.SaveChanges();

        }
        public void Update(Income Income, Income entity)
        {
          //  Income.TotalAmount = entity.TotalAmount;


            _IncomeContext.SaveChanges();
        }
        public void Delete(Income Income)
        {
            _IncomeContext.Income.Remove(Income);
            _IncomeContext.SaveChanges();
        }
        public int Sum(int id)
        {
           var income= _IncomeContext.Income.FirstOrDefault(e => e.Income_Id == id);
            var incomeCategory = _IncomeContext.IncomeCategory.Where(e => e.IC_Id == income.Income_Id).ToList();
                //FirstOrDefault(e => e.IC_Id == id);

            var T_Amount = incomeCategory.Sum(e => e.Amount);
            
            //Sum(incomeCategory.Amount);
               return T_Amount;
            //income.TotalAmount = T_Amount;
            //_IncomeContext.Income.Add(income);
        }

    }
}
