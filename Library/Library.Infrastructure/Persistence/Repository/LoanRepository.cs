using Library.Core.Entities;
using Library.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Persistense.Repository
{
    public class LoanRepository : ILoanRepository
    {
        public void CreateLoan(Loan user)
        {
            throw new NotImplementedException();
        }

        public void DeleteLoan(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Loan>> GetLoan()
        {
            throw new NotImplementedException();
        }

        public Task<Loan> GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateLoan(Guid id, Loan user)
        {
            throw new NotImplementedException();
        }
    }
}
