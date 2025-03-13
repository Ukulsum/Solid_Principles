using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Logger_System_DIP
{
    //Interface for logging
    public interface ILogger
    {
        void LogMessage(string message);
    }
}
