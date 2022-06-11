
namespace book_subscription_entity
{
    public class BookResult
    {
        public bool success { get; set; } = false;
        public string message { get; set; } = string.Empty;
        public List<Book> bookCatalogue { get; set; } = null;
    }
}