using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_System_OCP
{
    //Testing the Open-Closed Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            var emailChannel = new EmailNotification();
            var sender = new NotificationSender(emailChannel);
            sender.SendNotification("Hello via Email");

            var smsChannel = new SMSNotification();
            sender = new NotificationSender(smsChannel);
            sender.SendNotification("Hello via SMS!");

            Console.ReadKey();
        }
    }
}
