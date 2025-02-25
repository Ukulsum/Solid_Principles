using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_System_OCP
{
    //Modify the NotificationSender class to accept any INotificationChannel
    public class NotificationSender
    {
        private readonly INotificationChannel _channel;
        public NotificationSender(INotificationChannel channel)
        {
            _channel = channel;
        }

        public void SendNotification(string message) 
        { 
            _channel.Send(message);
        }
    }
}
