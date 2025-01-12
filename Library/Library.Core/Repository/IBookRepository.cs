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
        Task DeleteBookAsync(Guid id);
        Task UpdateBookAsync(Guid id, Book user);
        Task<List<Book>> GetBookAsync(string search, int page = 0, int size = 10);
        Task<Book> GetBookByIdAsync(Guid id);
    }
}
