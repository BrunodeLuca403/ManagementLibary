using FluentValidation;
using Library.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Validators
{
    public class CreateUsuarioCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUsuarioCommandValidator()
        {
            RuleFor(p => p.FullName).NotNull().MaximumLength(100).WithMessage("Informar o nome completo");
        }
    }
}
