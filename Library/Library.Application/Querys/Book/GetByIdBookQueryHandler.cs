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
    public class GetByIdBookQueryHandler : IRequestHandler<GetByIdBookQuery, ResultViewModel<GetByIdBookViewModel>>
    {
        private readonly IBookRepository _bookRepository;

        public GetByIdBookQueryHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        } 

        public async Task<ResultViewModel<GetByIdBookViewModel>> Handle(GetByIdBookQuery request, CancellationToken cancellationToken)
        {
            var id = await _bookRepository.GetBookByIdAsync(request.Id);

            if(id is null)
            {
                return ResultViewModel<GetByIdBookViewModel>.Error("Livro não encontrado");
            }

            var bookViewModel = new GetByIdBookViewModel(
                id.Title,
                id.Author,
                id.ISBN,
                id.Yearpublication
                );

            return ResultViewModel<GetByIdBookViewModel>.Success(bookViewModel);
        }
    }
}
