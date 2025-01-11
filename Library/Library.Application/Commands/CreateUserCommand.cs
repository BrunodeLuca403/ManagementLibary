using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Commands
{
    public class CreateUserCommand
    {
        public string FullName { get;  set; }
        public DateTime BirthDate { get;  set; }
        public string Email { get;  set; }
    }
}
