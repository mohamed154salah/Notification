using Notification.Configuration;

namespace Notification
{
    public interface INotification
    {
        public bool Send(IConfiguration config);
    }
}
