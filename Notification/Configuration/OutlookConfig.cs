using Notification.Configuration;

namespace Notification.Email
{
    public class OutlookConfig : IConfiguration
    {
        public bool Configure()
        {
           
                Console.WriteLine("Outlook Configured");
                return true;

        }

    }
}
