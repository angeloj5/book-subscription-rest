using System.ComponentModel.DataAnnotations.Schema;

namespace book_subscription_entity
{
    public class UserSubscription
    {
        public int UserSubscriptionid { get; set; }
        public bool active { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime? modificationdate { get; set; }
        [ForeignKey("bookid")]
        public Book book { get; set; }
        [ForeignKey("userid")]
        public User user { get; set; }
    }
}