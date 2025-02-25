using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_Mechanism_OCP
{
    public class Logger
    {
        private readonly ILogger _logger;
        public Logger (ILogger logger)
        {
            _logger = logger; 
        }

        public void LogMessage (string message)
        {
            _logger.LogMessage (message);
        }
   
    }
}
