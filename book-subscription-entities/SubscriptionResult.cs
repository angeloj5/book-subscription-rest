using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_subscription_entity
{
    public class SubscriptionResult
    {
        public bool subscribed { get; set; } = false;
        public string message { get; set; } = string.Empty;
        public string bookName { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public float newBalance { get; set; } = 0f;
    }
}