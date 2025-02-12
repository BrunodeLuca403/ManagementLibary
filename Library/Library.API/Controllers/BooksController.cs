
using Library.Application.Commands.Book;
using Library.Application.Querys.Book;
using Library.Application.ViewModels;
using Library.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/v1/Books")]
    public class BooksController : Controller
    {

        private IMediator _mediator;
        private readonly ILogger<BooksController> _logger;

        public BooksController(IMediator mediator, ILogger<BooksController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("/List-Book")]
        public async Task<ActionResult<List<GetAllBookViewModel>>> GetAllBook([FromQuery] ListBookQuery query)
        {
            var book = await _mediator.Send(query);    
            return Ok(book);
        }
        [HttpGet("/List-Book-id/{id}")]
        public async Task<ActionResult> GetByIdBook([FromQuery] Guid id)
        {
            var BookId = new GetByIdBookQuery(id);
            var book = await _mediator.Send(BookId);

            if(book is null) 
                   return NotFound();

            return Ok(book);
        }

        [HttpPost("/Create-Book")]
        public async Task<IActionResult> PostBook([FromBody] CreateBookCommand command)
        {
            var book = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetByIdBook), new { id = book }, command);
        }

        [HttpPut("/Update-Book")]
        public async Task<IActionResult> UpdateBook([FromBody] UpdateBookCommand command)
        {
            var book = await _mediator.Send(command);

            return Ok(book);
        }

        [HttpDelete("/Delete-Book")]
        public async Task<IActionResult> DeleteBook([FromBody] DeleteBookCommand command)
        {
            var book = await _mediator.Send(command);

            return Ok(book);
        }

    }
}
