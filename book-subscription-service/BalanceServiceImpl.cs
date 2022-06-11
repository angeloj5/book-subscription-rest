using book_subscription_context;
using book_subscription_entity;

namespace book_subscription_service
{
    public class BalanceServiceImpl : IBalanceService
    {
        private ApplicationDbContext MoDbContext = null;
        public ApplicationDbContext DbContext { set => MoDbContext = value; }

        public BalanceResult GetBalanceByUser(string PsEmail)
        {
            BalanceResult LoResult = new BalanceResult();
            try
            {
                Balance? LoBalance = MoDbContext.Balances.FirstOrDefault(LoItem => LoItem.user.email == PsEmail);

                if (LoBalance != null)
                {
                    LoResult.balanceAsOf = DateTime.Now;
                    LoResult.success = true;
                    LoResult.currentBalance = LoBalance.balance == null ? 0f : LoBalance.balance;
                    LoResult.email = PsEmail;
                }
            }
            catch (Exception LoException)
            {

                LoResult.success = false;
                LoResult.message = LoException.Message;
                LoResult.balanceAsOf = DateTime.Now;
                LoResult.currentBalance = 0f;
                LoResult.email = PsEmail;
            }
            return LoResult;
        }
    }
}