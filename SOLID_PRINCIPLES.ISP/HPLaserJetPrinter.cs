﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES.ISP
{
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
       

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan Content");
        }
        public void Fax(string content)
        {
            Console.WriteLine("Fax Content");
        }

        public void PrintDuplex(string content)
        {
            Console.WriteLine("Print Duplex Content");
        }

    }
}
