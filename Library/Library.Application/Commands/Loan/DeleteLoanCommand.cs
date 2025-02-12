using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.Loan
{
    public class DeleteLoanCommand : IRequest<Guid>
    {
        public Guid IdLoan { get; set; }
    }
}
