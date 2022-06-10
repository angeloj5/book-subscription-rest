using book_subscription_rest.Entities;
using Microsoft.AspNetCore.Mvc;

namespace book_subscription_rest.Controllers
{
    [ApiController]
    [Route("books")]
    public class booksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){bookid=1, name="IT",text="This is about a clown!", price=10.25f, creationdate=DateTime.Now, modificationdate=DateTime.Now},
                new Book(){bookid=2, name="The Lord of The Rings",text="This is about a ring!", price=15.25f, creationdate=DateTime.Now, modificationdate=DateTime.Now},
            };
        }
    }
}