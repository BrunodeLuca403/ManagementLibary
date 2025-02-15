using FluentValidation;
using Library.Application.Commands.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Validators
{
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        public UpdateUserCommandValidator()
        {
            RuleFor(p => p.Id).NotNull().Must(ValidarId).WithMessage("Informar o Id");

            RuleFor(p => p.FullName).NotNull().MaximumLength(100).WithMessage("Informar o nome completo");

            RuleFor(p => p.BirthDate).NotNull().WithMessage("Informar a data de nascimento");

            RuleFor(p => p.Email).NotNull().EmailAddress().WithMessage("Informar o email");
        }
        private bool ValidarId(Guid id)
        {
            return id != Guid.Empty;
        }

    }
}