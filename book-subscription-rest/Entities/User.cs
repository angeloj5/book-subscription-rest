namespace book_subscription_rest.Entities
{
    public class User
    {
        public int bookid { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public bool reseller { get; set; }
        public DateTime creationdate { get; set; }
        public DateTime? modificationdate { get; set; }
    }
}
