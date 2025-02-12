using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.ViewModels
{
    public class GetAllBookViewModel
    {
        public GetAllBookViewModel(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string Title { get;  set; }
        public string Author { get;  set; }
    }
}
