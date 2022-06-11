using book_subscription_context;
using book_subscription_entity;

namespace book_subscription_service
{
    public class SubscriptionServiceImpl : ISubscriptionService
    {
        private ApplicationDbContext MoDbContext = null;
        public ApplicationDbContext DbContext { set => MoDbContext = value; }
        public SubscriptionResult SubscribeToTitle(UserSubscription userSubscription)
        {
            return null;
        }
    }
}