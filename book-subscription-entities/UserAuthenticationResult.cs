using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_subscription_entity
{
    public class UserAuthenticationResult
    {
        public string email { get; set; } = string.Empty;
        public bool isAuthenticated { get; set; } = false;
        public string message { get; set; } = string.Empty;
    }
}