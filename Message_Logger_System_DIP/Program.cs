using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Logger_System_DIP
{ 
    //Testing the Dependency Inversion Principle 
    public class Program
    {
        public static void Main(string[] args)
        {
            //Now, when initializing the NotificationService, 
            //we can decide which logger to use:
            var consoleLogger = new ConsoleLogger();
            var notificationService1 = new NotificationService(consoleLogger);

            var fileLogger = new FileLogger("path_to_log_file.text");
            var notificationService2 = new NotificationService(fileLogger);

            Console.ReadKey();
        }
    }
}
