using Library.Application.ViewModels;
using Library.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Querys.Book
{
    public class ListBookQueryHandler : IRequestHandler<ListBookQuery, List<GetAllBookViewModel>>
    {
        private readonly IBookRepository _bookRepository;

        public ListBookQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<GetAllBookViewModel>> Handle(ListBookQuery request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetBookAsync();
            var bookViewModel  = book.Select(b => new GetAllBookViewModel( b.Title, b.Author)).ToList();
            return bookViewModel;
        }
    }
}
