using Library.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Querys.Loans
{
    public class GetAllLoansQuery : IRequest<List<GetAllLoansViewModel>>
    {
        //public Guid Id { get; set; }
    }
}
