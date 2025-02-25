using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_Mechanism_OCP
{
    public class DatabaseLogger : ILogger
    {
        public void LogMessage(string message)
        {
            // Logic to write the message to a database
            Console.WriteLine($"Logged to database: {message}");
        }
    }
}
