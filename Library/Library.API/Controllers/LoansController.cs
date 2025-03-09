using Library.Application.Commands.Loan;
using Library.Application.Querys.Book;
using Library.Application.Querys.Loans;
using Library.Application.ViewModels;
using Library.Core.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [ApiController]
    [Route("api/v1/Books")]
    [Authorize]

    public class LoansController : Controller
    {
        private IMediator _mediator;
        private readonly ILogger<BooksController> _logger;

        public LoansController(IMediator mediator, ILogger<BooksController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet("/listar-emprestimos")]
        public async Task<ActionResult<List<GetAllLoansViewModel>>> GetLoan([FromQuery] GetAllLoansQuery query)
        {
            var loans = await _mediator.Send(query);

            return Ok(loans);
        }

        [HttpGet("/List-Loan-id/{id}")]
        public async Task<ActionResult<GetByIdLoanViewModel>> GetByIdLoan([FromRoute] Guid id)
        {
            var query = new GetByIdLoanQuery(id);
            var book = await _mediator.Send(query);

            if (book is null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost("/emprestimos")]
        public async Task<ActionResult> CreateLoan([FromBody] CreateLoanCommand command)
        {
            var loans = await _mediator.Send(command);

            return Ok(loans);

        }

        [HttpPost("/delete-emprestimo")]
        public async Task<ActionResult> UpdateLoan([FromBody] DeleteLoanCommand command)
        {
            var loans = await _mediator.Send(command);
            return Ok(loans);

        }
    }
}
