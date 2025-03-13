using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Logger_System_DIP
{
    //Now, our NotificationService should depend on the abstraction
    public class NotificationService
    {
        private ILogger _logger;
        public NotificationService(ILogger logger)
        {
            _logger = logger;
        }

        public void Notify(string message)
        {
            // ... some notification logic ...
            _logger.LogMessage(message);

        }
    }
}
