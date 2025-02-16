using Library.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Querys.Loans
{
    public class GetByIdLoanQuery : IRequest<ResultViewModel<GetByIdLoanViewModel>>
    {
        public GetByIdLoanQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
