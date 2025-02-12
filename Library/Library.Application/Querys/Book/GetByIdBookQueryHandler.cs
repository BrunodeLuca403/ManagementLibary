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
    public class GetByIdBookQueryHandler : IRequestHandler<GetByIdBookQuery, GetByIdBookViewModel>
    {
        private readonly IBookRepository _bookRepository;

        public GetByIdBookQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        } 

        public async Task<GetByIdBookViewModel> Handle(GetByIdBookQuery request, CancellationToken cancellationToken)
        {
            var id = await _bookRepository.GetBookByIdAsync(request.Id);

            var bookViewModel = new GetByIdBookViewModel(
                id.Title,
                id.Author,
                id.ISBN,
                id.Yearpublication
                );

            return bookViewModel;
        }
    }
}
