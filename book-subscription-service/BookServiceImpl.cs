using book_subscription_context;
using book_subscription_entity;

namespace book_subscription_service
{
    public class BookServiceImpl : IBookService
    {
        private ApplicationDbContext MoDbContext = null;
        public ApplicationDbContext DbContext { set => MoDbContext = value; }
        public BookResult GetBookCatalogue()
        {
            BookResult LoResult = new BookResult();
            try
            {
                LoResult.bookCatalogue= MoDbContext.Books.ToList();
                LoResult.success = true;
            }
            catch(Exception LoException)
            {
                LoResult.bookCatalogue = null;
                LoResult.success = false;
                LoResult.message = LoException.Message;
            }
            return LoResult;
        }
    }
}