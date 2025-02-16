using Library.Application.ViewModels;
using Library.Core.Entities;
using Library.Core.Repository;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.User
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ResultViewModel>
    {
        private readonly IUserRepository _repository;

        public DeleteUserCommandHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResultViewModel> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetUserByIdAsync(request.Id);

            if(user is null)
            {
                return ResultViewModel.Error("Usuário não encontrado");
            }

            user.SetAsDeleted();
            await _repository.UpdateUserAsync(request.Id, user);
            return ResultViewModel.Success();
        }
    }
}
