﻿using Library.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Querys.Book
{
    public class ListBookQuery : IRequest<ResultViewModel<List<GetAllBookViewModel>>>
    {
    
    }
}
