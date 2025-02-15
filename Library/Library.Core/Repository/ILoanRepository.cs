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
        Task CreateLoanAsync(Loan loan);
        Task DeleteLoanAsync(Guid id);
        Task UpdateLoanAsync(Loan loan);
        Task<List<Loan>> GetLoanAsync();
        Task<Loan> GetUserByIdAsync(Guid id);
        Task UpdateDaysDelayAsync(Guid id);
    }
}
