using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_System_OCP
{
    //Implement this interface for each channel
    public class EmailNotification : INotificationChannel
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email : {message}");
        }
    }
}
