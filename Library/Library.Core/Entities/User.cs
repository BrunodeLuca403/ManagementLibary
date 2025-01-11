using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class User : BaseEntity
    {
   
        public User(string fullName, DateTime birthDate, string email) : base()
        {
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
            Loans = [];
        }

        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public List<Loan> Loans { get; private set; }
    }
}
