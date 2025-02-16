using Library.Application.ViewModels;
using Library.Core.Entities;
using Library.Core.Repository;
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

        public CreateUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Core.Entities.User(request.FullName, request.BirthDate,request.Email);

            await _repository.CreateUserAsync(user);
            return ResultViewModel<Guid>.Success(user.Id);
        }
    }
}
