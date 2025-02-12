using Library.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.Loan
{
    public class DeleteLoanCommandHandler : IRequestHandler<DeleteLoanCommand, Guid>
    {
        private readonly ILoanRepository _loanRepository;

        public DeleteLoanCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<Guid> Handle(DeleteLoanCommand request, CancellationToken cancellationToken)
        {
            
            
            var loan = await _loanRepository.GetUserByIdAsync(request.IdLoan);

            loan.SetAsDeleted();
            loan.Update();
            //await _loanRepository.DeleteLoanAsync(loan.Id);

            return loan.Id;
                  
        }
    }
}
