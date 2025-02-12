using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.ViewModels
{
    public class GetByIdBookViewModel
    {
        public GetByIdBookViewModel(string title, string author, string iSBN, string yearpublication)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Yearpublication = yearpublication;
        }

        public string Title { get;  set; }
        public string Author { get;  set; }
        public string ISBN { get;  set; }
        public string Yearpublication { get;  set; }
    }
}
