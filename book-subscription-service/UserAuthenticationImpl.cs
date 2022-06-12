using book_subscription_entity;
using book_subscription_context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_subscription_service
{
    public class UserAuthenticationImpl : IUserAuthentication
    {
        private ApplicationDbContext MoDbContext;
        public ApplicationDbContext DbContext { set => MoDbContext = value; }

        public UserAuthenticationResult AuthenticateUser(string PsEmail, string PsPassword)
        {
            try
            {
                MoDbContext.Users.Where(LoUser => LoUser.email == PsEmail && LoUser.password == PsPassword).First();
            }
            catch (Exception)
            {
                return new UserAuthenticationResult() { email = PsEmail, isAuthenticated = false, message = "Please check your email and password." };
            }
            return new UserAuthenticationResult() { email = PsEmail, isAuthenticated = true, message = string.Empty };
        }
    }
}
