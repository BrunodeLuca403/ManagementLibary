using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repository
{
    public interface IBookRepository
    {
        Task CreateBookAsync(Book user);
        Task UpdateBookAsync(Book user);
        Task<List<Book>> GetBookAsync();
        Task<Book> GetBookByIdAsync(Guid id);
    }
}
