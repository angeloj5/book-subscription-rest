
namespace book_subscription_entity
{
    public class BalanceResult
    {
        public string email { get; set; } = string.Empty;
        public float currentBalance { get; set; } = 0f;
        public DateTime balanceAsOf { get; set; } = DateTime.Now;
        public bool success { get; set; } = false;
        public string message { get; set; } = string.Empty;
    }
}