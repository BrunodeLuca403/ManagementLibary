using FluentValidation;
using Library.Application.Commands.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Validators
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(p => p.Title).NotNull().MaximumLength(60).MinimumLength(2).WithMessage("Informar o Titulo do livro");

            RuleFor(p => p.Author).NotNull().MaximumLength(100).MinimumLength(2).WithMessage("Informar o Author do livro");

            RuleFor(p => p.ISBN).NotNull().MaximumLength(100).MinimumLength(2).WithMessage("Informar o ISBN do livro");

            RuleFor(p => p.Yearpublication).NotNull().MaximumLength(4).MinimumLength(4).WithMessage("Informar o Yearpublication do livro");

        }
    }
}