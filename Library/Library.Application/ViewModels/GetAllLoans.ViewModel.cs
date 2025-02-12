using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.ViewModels
{
    public class GetAllLoansViewModel
    {
        public string User { get;  set; }
        public string Book { get;  set; }
        public DateTime DateLoan { get;  set; }
    }
}
