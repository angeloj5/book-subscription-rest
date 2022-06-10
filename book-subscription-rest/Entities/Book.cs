namespace book_subscription_rest.Entities
{
    public class Book
    {
        public int bookid { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public float price { get; set; }
        public DateTime creationdate { get; set; }
        public DateTime modificationdate { get; set; }
    }
}
