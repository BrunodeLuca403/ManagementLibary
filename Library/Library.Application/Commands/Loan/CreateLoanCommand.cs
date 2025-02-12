using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands.Loan
{
    public class CreateLoanCommand : IRequest<Guid>
    {
        public Guid IdUser { get;  set; }
        public Guid Idbook { get;  set; }
    }
}
