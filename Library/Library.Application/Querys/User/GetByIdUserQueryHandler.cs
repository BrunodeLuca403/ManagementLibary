using Library.Application.ViewModels;
using Library.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Querys.User
{
    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, ResultViewModel<GetByIdUserViewModel>>
    {
        private readonly IUserRepository _userRepository;
        public GetByIdUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ResultViewModel<GetByIdUserViewModel>> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            //var user = await _userRepository.GetUserByIdAsync(request.Id);

            //var loanViewModels = user.Loans.Select(loan => new GetAllLoansViewModel
            //{
            //    IdBook = loan.Idbook,
            //    DateLoan = loan.DateLoan,
            //    DaysDelay = loan.DaysDelay ?? 0
            //}).ToList();



            var user = await _userRepository.GetUserByIdAsync(request.Id);

            if(user is null)
            {
                return ResultViewModel<GetByIdUserViewModel>.Error("Usuário não encontrado");
            }

            var userViewModel = new GetByIdUserViewModel(user.FullName, user.BirthDate, user.Email);

            return ResultViewModel<GetByIdUserViewModel>.Success(userViewModel);
        }
    }
}
