using FluentValidation;
using Library.Application.Commands.Loan;
using Library.Application.Commands.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Validators
{
    public class DeleteLoanCommandValidator : AbstractValidator<DeleteLoanCommand>
    {
        public DeleteLoanCommandValidator()
        {
            RuleFor(p => p.IdLoan).NotNull().Must(ValidarId).WithMessage("Informar Id Loan");
        }

        private bool ValidarId(Guid id)
        {
            return id != Guid.Empty;
        }
    }
}
