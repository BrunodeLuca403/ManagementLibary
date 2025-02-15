using Library.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Querys.User
{
    public class GetByIdUserQuery : IRequest<GetByIdUserViewModel>
    {
        public GetByIdUserQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

    }
}
