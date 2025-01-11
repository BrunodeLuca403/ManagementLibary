using Library.Core.Entities;
using Library.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistense.Repository
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUser()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(Guid id, User user)
        {
            throw new NotImplementedException();
        }
    }
}
