
using Library.Core.Repository;
using Library.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.Loan
{
    public class CreateLoanCommandHandler : IRequestHandler<CreateLoanCommand, Guid>
    {
        private readonly ILoanRepository _loanRepository;

        public CreateLoanCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<Guid> Handle(CreateLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = new Core.Entities.Loan(request.IdUser, request.Idbook);
            await _loanRepository.CreateLoanAsync(loan);

            return loan.Id;

        }
    }
}
