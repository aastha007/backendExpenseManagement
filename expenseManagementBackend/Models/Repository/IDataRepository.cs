using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
         TEntity  GetByPrimaryKey(int id);
        IEnumerable<TEntity> GetByForeignKey(int id);
        void Add(TEntity entity);
        void Update(TEntity dbentity, TEntity entity);
        void Delete(TEntity entity);
        


    }
}
