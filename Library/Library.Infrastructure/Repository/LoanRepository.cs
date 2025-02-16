using Library.Core.Entities;
using Library.Core.Repository;
using Library.Infrastructure.Persistense.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Repository
{
    public class LoanRepository : ILoanRepository
    {
        private readonly LibraryDbContext _dbContext;

        public LoanRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateLoanAsync(Loan loan)
        {
            await _dbContext.Loans.AddAsync(loan);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteLoanAsync(Guid id)
        {
            var loan = await _dbContext.Loans.SingleOrDefaultAsync(p => p.Id == id);

            _dbContext.Loans.Remove(loan);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Loan>> GetLoanAsync()
        {
             return await _dbContext.Loans.Where(p => !p.IsDeleted).Include(p => p.User).Include(p => p.Book).ToListAsync();
        }

        public async Task<Loan> GetLoanByIdAsync(Guid id)
        {
            return await _dbContext.Loans.Include(p => p.User).Include(p => p.Book).SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateLoanAsync(Loan loan)
        {
            loan.Update();
            _dbContext.Loans.Update(loan);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateDaysDelayAsync(Guid id)
        {
            var loan = await _dbContext.Loans.SingleOrDefaultAsync(l => l.Id == id);

            if (loan != null)
            {
                int newDaysDelay = (loan.Datereturn < DateTime.Now) ? (DateTime.Now - loan.Datereturn).Days : 0;

                if (loan.DaysDelay != newDaysDelay) 
                {
                    loan.DaysDelay = newDaysDelay;
                    _dbContext.Loans.Update(loan);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
