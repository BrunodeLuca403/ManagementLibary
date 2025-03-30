using FluentAssertions;
using Library.Core.Entities;
using Library.Tests.Fakes;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests.Core
{
    public class BookTests
    {
        [Fact]
        public async Task Validade_Constructor_insert_Paramets_Corret()
        {
            var title = "Title Example";
            var author = "Author Example";
            var ISBN = "12345";
            var Yearpublication = "2020";
            var book = new Book(title, author, ISBN, Yearpublication);

            book.Should().NotBeNull();
            book.Title.Should().Be(title);
            book.Author.Should().Be(author);
            book.ISBN.Should().Be(ISBN);
            book.Yearpublication.Should().Be(Yearpublication);
            book.IsDeleted.Should().BeFalse();

        }
    }
}
