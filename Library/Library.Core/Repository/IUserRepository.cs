using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repository
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        void DeleteUser(Guid id);
        void UpdateUser(Guid id, User user); 
        Task<List<User>> GetUser();
        Task<User> GetUserById(Guid id);


    }
}
