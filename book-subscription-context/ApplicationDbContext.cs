using book_subscription_entity;
using Microsoft.EntityFrameworkCore;

namespace book_subscription_context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserSubscription> usersubscriptions { get; set; }
    }
}