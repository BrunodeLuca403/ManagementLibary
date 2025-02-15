
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
            int daysDelay = (request.DateReturn < DateTime.Now) ? (DateTime.Now - request.DateReturn).Days : 0;

            var loan = new Core.Entities.Loan(request.IdUser, request.Idbook, request.DateReturn, daysDelay);
            await _loanRepository.CreateLoanAsync(loan);

            return loan.Id;

        }
    }
}
