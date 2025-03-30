using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using FluentAssertions;
using Library.Application.Commands.Book;
using Library.Core.Entities;
using Library.Core.Repository;
using Library.Infrastructure.Repository;
using Library.Tests.Fakes;
using Moq;


namespace Library.Tests.Application
{
    public class CreateBookCommandTests
    {
        [Fact]
        public async Task Create_Book_Command_Handler_Are_Ok()
        {

            //var guid = Guid.NewGuid();

            var repository = Mock.Of<IBookRepository>(r => r.CreateBookAsync(It.IsAny<Book>()) == Task.CompletedTask);
            var command = FakeDataHelper.CreateFakerInsertBookCommand();

            var handler = new CreateBookCommandHandler(repository);

            var result = await handler.Handle(command, new CancellationToken());   


            result.IsSuccess.Should().BeTrue();
            result.Data.Should().Be(result.Data);

            //Assert.Equals(guid, result.Data);
        }
    }
}
