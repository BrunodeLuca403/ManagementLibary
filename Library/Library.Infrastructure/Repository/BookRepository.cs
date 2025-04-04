﻿using Library.Core.Entities;
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
    public class BookRepository : IBookRepository
    {
        private readonly LibraryDbContext _dbContext;

        public BookRepository(LibraryDbContext dbContext)
        {
                _dbContext = dbContext;
        }
        public async Task CreateBookAsync(Book user)
        {
             _dbContext.Books.AddAsync(user);
             _dbContext.SaveChangesAsync();
         
        }

        public async Task<List<Book>> GetBookAsync()
        {
           return await _dbContext.Books.Where(p => !p.IsDeleted).ToListAsync();
      
        }

        public async Task<Book> GetBookByIdAsync(Guid id)
        {
            return await _dbContext.Books.SingleOrDefaultAsync(p => p.Id == id);
            
        }

        public async Task UpdateBookAsync(Book book)
        {
            //var book = await _dbContext.Books.SingleOrDefaultAsync(p => p.Id == id);
            book.Update(book.Title, book.Author, book.ISBN, book.Yearpublication);
            _dbContext.Books.Update(book);
            _dbContext.SaveChangesAsync();
        }
    }
}
