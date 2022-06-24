using Cqrs.Core.Api.Data;
using Cqrs.Core.Api.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Cqrs.Core.Api.Features.Books
{
    public class GetBooks
    {
        public class Query : IRequest<IEnumerable<Book>> { }

        public class QueryHandler : IRequestHandler<Query, IEnumerable<Book>>
        {
            private readonly BookContext _db;

            public QueryHandler(BookContext db) => _db = db;

            public async Task<IEnumerable<Book>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _db.Books.ToListAsync(cancellationToken);
            }
        }
    }
}
