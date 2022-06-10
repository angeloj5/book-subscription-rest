using book_subscription_rest.Entities;
using Microsoft.EntityFrameworkCore;

namespace book_subscription_rest
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}