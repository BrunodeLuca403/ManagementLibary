using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.ViewModels
{
    public class GetAllLoansViewModel
    {
        public GetAllLoansViewModel( string userEmail,  string bookTitle, DateTime dateLoan, DateTime dateReturn, int? daysDalay)
        {
            UserEmail = userEmail;
            BookTitle = bookTitle;
            DateLoan = dateLoan;
            DateReturn = dateReturn;
            DaysDalay = daysDalay;
        }

        public string UserEmail { get; set; }
        public string BookTitle { get; set; }
        public DateTime DateLoan { get;  set; }
        private DateTime DateReturn { get; set; }
        public int? DaysDalay { get; set; }

    }
}
