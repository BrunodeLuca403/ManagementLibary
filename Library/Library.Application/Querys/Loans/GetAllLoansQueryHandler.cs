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
    public class GetAllLoansQueryHandler : IRequestHandler<GetAllLoansQuery, List<GetAllLoansViewModel>>
    {
        private readonly ILoanRepository _loanRepository;

        public GetAllLoansQueryHandler(ILoanRepository loanRepository)
        {
            _loanRepository = loanRepository;
        }

        public async Task<List<GetAllLoansViewModel>> Handle(GetAllLoansQuery request, CancellationToken cancellationToken)
        {
            var loan = await _loanRepository.GetLoanAsync();
            //await _loanRepository.UpdateDaysDelayAsync(request.Id);

            var bookViewModel = loan.Select(b => new GetAllLoansViewModel(b.User.Email, b.Book.Title, b.DateLoan, b.Datereturn, b.DaysDelay)).ToList();
            return bookViewModel;
        }
    }
}
