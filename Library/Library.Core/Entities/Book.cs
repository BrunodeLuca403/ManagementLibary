using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string author, string iSBN, string yearpublication) : base()
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Yearpublication = yearpublication;
            Loans= [];
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string ISBN { get; private set; }
        public string Yearpublication { get; private set; }
        public List<Loan> Loans { get; private set; }

        public void Update(string title, string author, string iSBN, string yearpublication)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Yearpublication = yearpublication;

        }
    }
}
