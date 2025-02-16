using Library.Application.ViewModels;
using Library.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.Loan
{
    public class DeleteLoanCommandHandler : IRequestHandler<DeleteLoanCommand, ResultViewModel<Guid>>
    {
        private readonly ILoanRepository _loanRepository;

        public DeleteLoanCommandHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<ResultViewModel<Guid>> Handle(DeleteLoanCommand request, CancellationToken cancellationToken)
        {
            var loan = await _loanRepository.GetLoanByIdAsync(request.IdLoan);

            if(loan is null)
            {
                return ResultViewModel<Guid>.Error("Emprestimo não encontrado");
            }

            loan.SetAsDeleted();
            loan.Update();

            return ResultViewModel<Guid>.Success(loan.Id);
                  
        }
    }
}
