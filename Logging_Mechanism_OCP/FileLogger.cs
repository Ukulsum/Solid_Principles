using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_Mechanism_OCP
{
    //Implement the interface for each logging type
    public class FileLogger : ILogger
    {
        public void LogMessage (string message)
        {
            // Logic to write the message to a file
            Console.WriteLine ($"Logged to file : {message}");
        }
    }
}
