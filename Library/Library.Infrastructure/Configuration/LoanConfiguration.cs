using Library.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Configuration
{
    internal class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(l => l.Id);

            builder.HasOne(l => l.User)
                   .WithMany(l => l.Loans)
                   .HasForeignKey(l => l.IdUser)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(l => l.Book)
                    .WithMany(l => l.Loans)
                    .HasForeignKey(l => l.Idbook)
                    .OnDelete(DeleteBehavior.Restrict);
           
        }
    }
}
