using Azure;
using Library.Core.Entities;
using Library.Core.Repository;
using Library.Infrastructure.Persistense.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryDbContext _dbContext;

        public UserRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        //public async Task<List<User>> GetUserAsync(string search,int page = 0, int size = 10)
        //{
        //   return await _dbContext.Users.Include(p => p.Loans)
        //                                .Where(p => !p.IsDeleted || 
        //                                       search == "" || 
        //                                       search == p.FullName || 
        //                                       search == p.Email)
        //                                .Skip(page + size)
        //                                .Take(size)
        //                                .ToListAsync();

        //}

        public async Task<User> GetUserByIdAsync(Guid id)
        {
            return await _dbContext.Users.Include(p => p.Loans).SingleOrDefaultAsync(x => x.Id == id);
        }

        public  User LoginUser(string Email, string password)
        {
            return  _dbContext.Users.SingleOrDefault(p => p.Email == Email && p.Password == password);

            
        }

        public async Task UpdateUserAsync(Guid id, User user)
        {
            var searchUser = await _dbContext.Users.SingleOrDefaultAsync(p => p.Id == id);
            user.Update(searchUser.FullName, searchUser.BirthDate, searchUser.Email);
            _dbContext.Users.Update(searchUser);
            await _dbContext.SaveChangesAsync();
        }
    }
}
