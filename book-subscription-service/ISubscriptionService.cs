﻿
using book_subscription_context;
using book_subscription_entity;

namespace book_subscription_service
{
    public interface ISubscriptionService
    {
        public ApplicationDbContext DbContext { set; }
        public SubscriptionResult SubscribeToTitle(UserSubscription userSubscription);
    }
}