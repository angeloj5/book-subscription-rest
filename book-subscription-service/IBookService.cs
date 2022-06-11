using book_subscription_context;
using book_subscription_entity;

namespace book_subscription_service
{
    public interface IBookService
    {
        public ApplicationDbContext DbContext { set; }
        public BookResult GetBookCatalogue();
    }
}