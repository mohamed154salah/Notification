using Notification.Configuration;

namespace Notification.Email
{
    public class GmailConfig : IConfiguration
    {
        public bool Configure()
        {

            Console.WriteLine("Gmail Configured");
            return true;

        }
    }
}
