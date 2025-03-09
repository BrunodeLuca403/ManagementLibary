using FluentValidation;
using Library.Application.Commands.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Validators
{
    public class CreateLoanCommandValidator : AbstractValidator<CreateLoanCommand>
    {
        public CreateLoanCommandValidator()
        {
            RuleFor(p => p.Idbook).NotNull().Must(ValidarId).WithMessage("Informar Id Book");
            RuleFor(p => p.IdUser).NotNull().Must(ValidarId).WithMessage("Informar Id User");

        }

        private bool ValidarId(Guid id)
        {
            return id != Guid.Empty;
        }
    }
}
