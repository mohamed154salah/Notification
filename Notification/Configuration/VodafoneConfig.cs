using Notification.Configuration;

namespace Notification.Sms
{
    public class VodafoneConfig : IConfiguration
    {
        public bool Configure()
        {
            
                Console.WriteLine("Vodafone Configured");
                return true;

           
        }
    }
}
