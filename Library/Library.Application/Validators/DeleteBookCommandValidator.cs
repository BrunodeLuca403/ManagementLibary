using FluentValidation;
using Library.Application.Commands.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Validators
{
    public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
    {
        public DeleteBookCommandValidator()
        {
            RuleFor(p => p.Id).NotNull().Must(ValidarId).WithMessage("Informar Id");

        }

        private bool ValidarId(Guid id)
        {
            return id != Guid.Empty;
        }
    }
}
