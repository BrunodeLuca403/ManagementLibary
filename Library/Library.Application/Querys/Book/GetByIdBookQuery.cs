using Library.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Querys.Book
{
    public class GetByIdBookQuery : IRequest<GetByIdBookViewModel>
    {
        public GetByIdBookQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
