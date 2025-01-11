using Library.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Repository
{
    public interface ILoanRepository
    {
        void CreateLoan(Loan user);
        void DeleteLoan(Guid id);
        void UpdateLoan(Guid id, Loan user);
        Task<List<Loan>> GetLoan();
        Task<Loan> GetUserById(Guid id);
    }
}
