using Library.Core.Entities;
using Library.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistense.Repository
{
    public class BookRepository : IBookRepository
    {
        public void CreateBook(Book user)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetBook()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookById(Book id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Guid id, Book user)
        {
            throw new NotImplementedException();
        }
    }
}
