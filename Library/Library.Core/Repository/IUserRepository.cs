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
        Task CreateUserAsync(User user);
        Task DeleteUserAsync(Guid id);
        Task UpdateUserAsync(Guid id, User user); 
        Task<List<User>> GetUserAsync(string search, int page = 0, int size = 10);
        Task<User> GetUserByIdAsync(Guid id);


    }
}
