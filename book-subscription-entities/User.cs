namespace book_subscription_entity
{ 
    public class User
    {
        public int userid { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public bool reseller { get; set; }
        public string password { get; set; }
        public DateTime creationdate { get; set; }
        public DateTime? modificationdate { get; set; }
    }
}
