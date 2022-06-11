using book_subscription_context;
using book_subscription_entity;
using book_subscription_service;
using Microsoft.AspNetCore.Mvc;

namespace book_subscription_rest.Controllers
{
    [ApiController]
    [Route("balance")]
    public class balanceController : ControllerBase
    {
        private readonly ApplicationDbContext MoDbContext;

        IBalanceService MoBalanceService;

        public balanceController(ApplicationDbContext PoDbCOntext)
        {
            MoDbContext = PoDbCOntext;
        }

        [HttpGet("{email}")]
        public ActionResult<BalanceResult> GetBalance(string PsEmail)
        {
            MoBalanceService = new BalanceServiceImpl();
            MoBalanceService.DbContext = MoDbContext;
            return MoBalanceService.GetBalanceByUser(PsEmail);
        }
    }
}