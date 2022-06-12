using book_subscription_context;
using book_subscription_entity;

namespace book_subscription_service
{
    public class SubscriptionServiceImpl : ISubscriptionService
    {
        private ApplicationDbContext MoDbContext = null;
        public ApplicationDbContext DbContext { set => MoDbContext = value; }
        public SubscriptionResult SubscribeToTitle(string PsUserEmail, int PiBookId)
        {
            int LiUserId = 0;
            SubscriptionResult LoResult;
            Book? LoBook = null;


            User? LoUser = MoDbContext.Users.FirstOrDefault(LoItem => LoItem.email == PsUserEmail);

            if (LoUser == null)
                return new SubscriptionResult() { email = PsUserEmail };

            LiUserId = LoUser.userid;

            Balance? LoBalance = MoDbContext.Balances.FirstOrDefault(LoRow => LoRow.user.userid == LiUserId);

            if (LoBalance != null)
                if (LoBalance.balance > 0f)
                    LoBook = MoDbContext.Books.FirstOrDefault(LoRow => LoRow.bookid == PiBookId);

            if (LoBook == null)
                return new SubscriptionResult() { message = "The book doesn't exists.", subscribed = false };

            if (LoBook.price <= LoBalance.balance)
            {
                MoDbContext.Add(new UserSubscription() { active = true, book = LoBook, creationDate = DateTime.Now, modificationdate = DateTime.Now, user = LoUser });


                LoBalance.balance = LoBalance.balance - LoBook.price;
                MoDbContext.Update(LoBalance);

                MoDbContext.SaveChanges();
                return new SubscriptionResult() { message = "You are now subscribed to the book, enjoy!", subscribed = true };
            }
            else
                return new SubscriptionResult() { message = "You were not subscribed to the book. Please check your balance.", subscribed = false };

        }

        SubscriptionResult ISubscriptionService.UnSubscribeToATitle(string PsUserEmail, int PiBookId)
        {
            SubscriptionResult LoResult;

            UserSubscription? LoSubscription = MoDbContext.usersubscriptions.FirstOrDefault(LoSubscription => LoSubscription.user.email == PsUserEmail && LoSubscription.book.bookid == PiBookId);

            if (LoSubscription == null)
                return new SubscriptionResult() { subscribed = false, message = "You are nor subscribed to that title yet.", email = PsUserEmail };

            MoDbContext.Remove(LoSubscription);
            MoDbContext.SaveChanges();

            return new SubscriptionResult() { subscribed = false, message = "You are no longer subscribed to the title.", email = PsUserEmail }; ;
        }
    }
}