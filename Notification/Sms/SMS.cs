using Notification.Configuration;
using Notification.Email;
using Notification.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Sms
{
    public class SMS : INotification
    {
        public string Message { get; private set; }
        public SMS(string message)
        {
            Message = message;
        }

        public bool Send(IConfiguration config)
        {

            config.Configure();
            Print.PrintSMS(new SMS(Message));
            return true;

        }

    }
}
