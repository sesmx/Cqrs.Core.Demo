using Cqrs.Core.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Cqrs.Core.Api.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
