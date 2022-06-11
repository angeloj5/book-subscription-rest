using book_subscription_context;
using book_subscription_entity;

namespace book_subscription_service
{
    public interface IBalanceService
    {
        public ApplicationDbContext DbContext { set; }
        public BalanceResult GetBalanceByUser(string PsEmail);
    }
}