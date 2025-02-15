using Library.Application.Commands.Book;
using Library.Application.Commands.User;
using Library.Application.Querys.Book;
using Library.Application.Querys.User;
using Library.Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/v1/Books")]
    public class UserController : Controller
    {
        private IMediator _mediator;
        private readonly ILogger<BooksController> _logger;

        public UserController(IMediator mediator, ILogger<BooksController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("/List-User-id/{id}")]
        public async Task<ActionResult> GetByIdUser([FromRoute] Guid id)
        {
            var UserId = new GetByIdUserQuery(id);
            var book = await _mediator.Send(UserId);

            if (UserId is null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost("/Create-User")]
        public async Task<ActionResult> PostUser([FromBody] CreateUserCommand command)
        {
            var user = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetByIdUser), new { id = user }, command);
        }

        [HttpPut("/Update-User")]
        public async Task<ActionResult> UpdateUser([FromBody] UpdateUserCommand command)
        {
            var book = await _mediator.Send(command);

            return Ok(book);
        }


        [HttpDelete("/Delete-user")]
        public async Task<ActionResult> DeleteBook([FromBody] DeleteUserCommand command)
        {
            var book = await _mediator.Send(command);

            return Ok(book);
        }
    }
}
