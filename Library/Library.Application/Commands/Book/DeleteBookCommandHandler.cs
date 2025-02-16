using Library.Application.ViewModels;
using Library.Core.Repository;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.Book
{
    public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand, ResultViewModel>
    {
        private readonly IBookRepository _bookRepository;

        public DeleteBookCommandHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ResultViewModel> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetBookByIdAsync(request.Id);
            if (book is null)
                return ResultViewModel.Error("Livro não encontrado!");

            book.SetAsDeleted();
            await _bookRepository.UpdateBookAsync(book);
            return ResultViewModel.Success();

        }
    }
}
