using book_subscription_context;
using book_subscription_entity;
using book_subscription_service;
using Microsoft.AspNetCore.Mvc;

namespace book_subscription_rest.Controllers
{
    [ApiController]
    [Route("books")]
    public class booksController : ControllerBase
    {
        private readonly ApplicationDbContext MoDbContext;

        IBookService MoBookService;
        ISubscriptionService MoSubscriptionService;

        public booksController(ApplicationDbContext PoDbContext)
        {
            MoDbContext = PoDbContext;
        }

        [HttpGet]
        public ActionResult<BookResult> GetBooks()
        {
            MoBookService = new BookServiceImpl();
            MoBookService.DbContext = MoDbContext;
            return MoBookService.GetBookCatalogue();
        }
    }
}