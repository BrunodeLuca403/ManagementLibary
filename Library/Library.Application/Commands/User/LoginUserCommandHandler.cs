using Library.Application.ViewModels;
using Library.Core.Repository;
using Library.Infrastructure.Auth;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.User
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, ResultViewModel<LoginViewModel>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IAuthService _authService;

        public LoginUserCommandHandler(IUserRepository userRepository, IAuthService authService)
        {
            _userRepository = userRepository;
            _authService = authService;
        }

        public async Task<ResultViewModel<LoginViewModel>> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeHash(request.Password);
            var user = _userRepository.LoginUser(request.Email, passwordHash);

            if(user is null)
            {
                ResultViewModel.Error("Usuário ou senha incorretos");
            }

            var token = _authService.GenerateToken(user.Email, user.Role);
            var tokenUserViewModel = new LoginViewModel(token);
            var result = ResultViewModel<LoginViewModel>.Success(tokenUserViewModel);

            return result;
        }
    }
}
