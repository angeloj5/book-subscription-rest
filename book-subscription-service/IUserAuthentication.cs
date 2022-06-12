using book_subscription_entity;
using book_subscription_context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_subscription_service
{
    public interface IUserAuthentication
    {
        public ApplicationDbContext DbContext { set; }

        public UserAuthenticationResult AuthenticateUser(string PsEmail, string PsPassword);
    }
}
