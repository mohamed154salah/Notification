using Notification.Configuration;

namespace Notification.Sms
{
    public class WeConfig : IConfiguration
    {
        public bool Configure()
        {
           
                Console.WriteLine("We Configured");
                return true;

           
        }

    }
}
