using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class User : BaseEntity
    {
   
        public User(string fullName, DateTime birthDate, string email, string password, string role) : base()
        {
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
            Password = password;
            Role = role;
            Loans = [];
        }

        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Email { get; private set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<Loan> Loans { get; private set; }


        public void Update(string fullname, DateTime birthDate, string email)
        {
            FullName = fullname;
            BirthDate = birthDate;
            Email = email;

        }
    }
}
