using Bogus;
using Bogus.Extensions.Brazil;
using Library.Application.Commands.Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Tests.Fakes
{
    public class FakeDataHelper
    {
        private static readonly Faker _faker = new();

        private static readonly Faker<CreateBookCommand> _createBookCommand = new Faker<CreateBookCommand>()
          .RuleFor(c => c.Title, f => f.Company.CompanyName())
          .RuleFor(c => c.Author, f => f.Person.FirstName)
          .RuleFor(c => c.ISBN, f => f.Person.Cpf())
          .RuleFor(C => C.Yearpublication, f => f.Date.Month());

        public static CreateBookCommand CreateFakerInsertBookCommand() => _createBookCommand.Generate();



    }
}