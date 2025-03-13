using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message_Logger_System_DIP
{
    public class FileLogger : ILogger
    {
        private string _filePath;
        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }
        public void LogMessage(string message)
        {
            // Just a simple example. In a real-world scenario, proper exception handling and file IO management is needed.
            File.AppendAllText(_filePath, message);
        }
    }
}
