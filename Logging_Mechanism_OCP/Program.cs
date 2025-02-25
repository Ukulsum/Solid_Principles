using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_Mechanism_OCP
{
    //Testing the Open-Closed Principle
    public class Program
    {
        static void Main(string[] args)
        {
            var fileLogger = new FileLogger();
            var logger = new Logger(fileLogger);
            logger.LogMessage("This is a file log.");

            var dbLogger = new DatabaseLogger();
            logger = new Logger(dbLogger);
            logger.LogMessage("This is a database log.");

            Console.ReadKey();
        }
    }
}
