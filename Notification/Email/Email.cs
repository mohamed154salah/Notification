using Notification.Configuration;

namespace Notification.Email
{
    public class Email : INotification
    {
        public string Body { get; private set; }
        public string From { get; private set; }
        public string To { get; private set; }

        public string[]? CC { get; private set; }


        public Email(string body, string from, string to, string[]? cc = null)
        {
            Body = body;
            From = from;
            To = to;
            CC = cc;
        }

        public bool Send(IConfiguration config)
        {
            config.Configure();
            Print.PrintEmail(new Email(Body, From, To, CC));
            return true;

        }

    }
}
