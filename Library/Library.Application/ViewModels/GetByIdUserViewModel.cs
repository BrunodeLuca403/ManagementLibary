using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.ViewModels
{
    public class GetByIdUserViewModel
    {
        public GetByIdUserViewModel(string fullName, DateTime birthDate, string email)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;

        }

        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
    }
}
