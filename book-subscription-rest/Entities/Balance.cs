namespace book_subscription_rest.Entities
{
    public class Balance
    {
        
        public int balanceid { get; set; }
        public float balance { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime? modificationDate { get; set; }
        public User user { get; set; }
    }
}
