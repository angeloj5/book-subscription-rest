namespace book_subscription_rest.Entities
{
    public class User_Subscription
    {
        public int subscrption { get; set; }
        public bool active { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime? modificationdate { get; set; }
        public Book book { get; set; }
        public User user { get; set; }
    }
}