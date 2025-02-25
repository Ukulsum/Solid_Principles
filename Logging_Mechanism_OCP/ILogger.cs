using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_Mechanism_OCP
{
    //Define an interface for logging
    public interface ILogger
    {
        void LogMessage (string message);
    }
}
