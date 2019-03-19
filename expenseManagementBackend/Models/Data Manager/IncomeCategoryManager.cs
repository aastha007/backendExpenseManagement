
using expenseManagementBackend.Models.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models.Data_Manager
{
    public class IncomeCategoryManager: IDataRepository<IncomeCategory>
    {

        readonly dbContext _IncomeCategoryContext;
        public IncomeCategoryManager(dbContext context)
        {
            _IncomeCategoryContext = context;
        }
        public IEnumerable<IncomeCategory> GetAll()
        {
            return _IncomeCategoryContext.IncomeCategory.ToList();
        }

        public IncomeCategory GetByPrimaryKey(int id)
        {
            return _IncomeCategoryContext.IncomeCategory.FirstOrDefault((e) => e.IC_Id == id);

        }

        public IEnumerable<IncomeCategory> GetByForeignKey(int id)
        {
            return _IncomeCategoryContext.IncomeCategory.Where((e) => e.User_Id == id).ToList();

        }
        public void Add(IncomeCategory Entity)
        {
            _IncomeCategoryContext.IncomeCategory.Add(Entity);
            _IncomeCategoryContext.SaveChanges();

        }
        public void Update(IncomeCategory IncomeCategory, IncomeCategory entity)
        {
            IncomeCategory.Date = entity.Date;
            IncomeCategory.Description = entity.Description;
            IncomeCategory.Amount = entity.Amount;
            IncomeCategory.Income_Category = entity.Income_Category;


            _IncomeCategoryContext.SaveChanges();
        }
        public void Delete(IncomeCategory IncomeCategory)
        {
            _IncomeCategoryContext.IncomeCategory.Remove(IncomeCategory);
            _IncomeCategoryContext.SaveChanges();
        }

       
    }
}
