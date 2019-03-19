using expenseManagementBackend.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expenseManagementBackend.Models.Data_Manager
{
    public class UserFake:IDataRepository<user>
    {
        private readonly List<user> _user;
        public UserFake()
        {
            _user = new List<user>()
            {
                new user()
                {
                    User_Id=1, First_name="Aastha", Last_name="Kansal", Email="aastha7195@gmail.com", Password="12345678"

                },
                new user()
                {
                    User_Id=2, First_name="Sakshi", Last_name="Jain", Email="sakshi@gmail.com", Password="87654321"
                }
            };
        }

        public void Add(user entity)
        {
            _user.Add(entity);
        }

        public void Delete(user entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<user> GetAll()
        {
            return _user;
        }

        public IEnumerable<user> GetByForeignKey(int id)
        {
            throw new NotImplementedException();
        }

        public user GetByPrimaryKey(int id)
        {
            return _user.Where(m => m.User_Id == id).FirstOrDefault();
        }

        public void Update(user dbentity, user entity)
        {
            throw new NotImplementedException();
        }
    }
}
