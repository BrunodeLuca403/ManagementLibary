using Library.Application.ViewModels;
using Library.Core.Entities;
using Library.Core.Repository;
using Library.Infrastructure.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.User
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ResultViewModel<Guid>>
    {
        private readonly IUserRepository _repository;
        private readonly IAuthService _authService;
        public CreateUserCommandHandler(IUserRepository repository, IAuthService authService)
        {
            _repository = repository;
            _authService = authService;
        }

        public async Task<ResultViewModel<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeHash(request.Password);
            var user = new Core.Entities.User(request.FullName, request.BirthDate,request.Email, passwordHash, request.Role);

            await _repository.CreateUserAsync(user);
            return ResultViewModel<Guid>.Success(user.Id);
        }
    }
}
