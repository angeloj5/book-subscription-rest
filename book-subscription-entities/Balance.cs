using System.ComponentModel.DataAnnotations.Schema;

namespace book_subscription_entity
{
    public class Balance
    {
        public int balanceid { get; set; }
        public float balance { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime? modificationDate { get; set; }
        [ForeignKey("userid")]
        public User user { get; set; }
    }
}
