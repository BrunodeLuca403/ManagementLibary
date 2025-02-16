using Library.Application.ViewModels;
using Library.Core.Entities;
using Library.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.Book
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, ResultViewModel<Guid>>
    {
        private readonly IBookRepository _respository;

        public CreateBookCommandHandler(IBookRepository respository)
        {
            _respository = respository;
        }

        public async Task<ResultViewModel<Guid>> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = new Core.Entities.Book(request.Title, request.Author, request.ISBN, request.Yearpublication);
            await _respository.CreateBookAsync(book);
            return ResultViewModel<Guid>.Success(book.Id);
        }
    }
}
