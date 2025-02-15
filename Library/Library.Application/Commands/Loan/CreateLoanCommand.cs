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
        public CreateLoanCommand(Guid idUser, Guid idbook, DateTime dateReturn, int? daysDalay)
        {
            IdUser = idUser;
            Idbook = idbook;
            DateReturn = dateReturn;
            DaysDalay = daysDalay;
        }

        public Guid IdUser { get;  set; }
        public Guid Idbook { get;  set; }
        public DateTime DateReturn { get; set; }
        public int? DaysDalay { get; set; }
    }
}
