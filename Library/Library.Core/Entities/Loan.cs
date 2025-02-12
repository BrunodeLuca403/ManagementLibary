using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Loan : BaseEntity
    {
        public Loan(Guid idUser, Guid idbook) : base()
        {
            IdUser = idUser;
            Idbook = idbook;
            DateLoan = DateTime.Now;
        }

        public Guid IdUser { get; private set; }
        public User User { get; private set; }
        public Guid Idbook { get; private set; }
        public Book Book { get; private set; }
        public DateTime DateLoan { get; private set; }

        public void Update()
        {
           

        }
    }
}
