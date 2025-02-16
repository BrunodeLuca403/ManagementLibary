using Library.Application.ViewModels;
using Library.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Querys.Loans
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdLoanQuery, ResultViewModel<GetByIdLoanViewModel>>
    {
        private readonly ILoanRepository _loanRepository;

        public GetByIdQueryHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }
        public async Task<ResultViewModel<GetByIdLoanViewModel>> Handle(GetByIdLoanQuery request, CancellationToken cancellationToken)
        {
            var loan = await _loanRepository.GetLoanByIdAsync(request.Id);
            await _loanRepository.UpdateDaysDelayAsync(request.Id);

            if(loan is null)
            {
                return ResultViewModel<GetByIdLoanViewModel>.Error("Emprestimo não encontrado");
            }

            var LoanViewModel = new GetByIdLoanViewModel(
                loan.User.Email,
                loan.Book.Title,
                loan.DateLoan,
                loan.Datereturn,
                loan.DaysDelay
                );

            return ResultViewModel<GetByIdLoanViewModel>.Success(LoanViewModel);
        }
    }
}
