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
        void CreateBook(Book user);
        void DeleteBook(Guid id);
        void UpdateBook(Guid id, Book user);
        Task<List<Book>> GetBook();
        Task<Book> GetBookById(Book id);
    }
}
