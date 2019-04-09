using expenseManagementBackend.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models.Data_Manager
{
    public class UserManager:IDataRepository<user>
    {

        readonly dbContext _userContext;
        public UserManager (dbContext context)
        {
            _userContext = context;
        }
        public IEnumerable<user> GetAll()
        {
            return _userContext.user.ToList();
        }
        public user GetByPrimaryKey(int id)
        {
            return _userContext.user.FirstOrDefault(e => e.User_Id == id);

        }
        public IEnumerable<user> GetByForeignKey(string id)
        {
            return _userContext.user.ToList();
        }

        public void Add(user Entity)
        {
            _userContext.user.Add(Entity);
            _userContext.SaveChanges();

        }
        public void Update(user user , user entity)
        {
            user.First_name = entity.First_name;
            user.Last_name = entity.Last_name;
            user.Email = entity.Email;
            user.Password = entity.Password;
           // user.Balance = entity.Balance;

            _userContext.SaveChanges();
        }
        public void Delete(user user)
        {
            _userContext.user.Remove(user);
            _userContext.SaveChanges();
        }

    }
}
