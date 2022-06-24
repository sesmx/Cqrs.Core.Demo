using Cqrs.Core.Api.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.Core.Api.Features.Books
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _mediator.Send(new GetBooks.Query());
        }

        [HttpGet("{id}")]
        public async Task<Book> GetBook(int id)
        {
            return await _mediator.Send(new GetBookById.Query { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult> CreateBook([FromBody] AddNewBook.Command command)
        {
            var createdBookId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetBook), new { id = createdBookId }, null);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            await _mediator.Send(new DeleteBook.Command { Id = id });
            return NoContent();
        }
    }
}
