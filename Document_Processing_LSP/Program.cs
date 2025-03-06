using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Processing_LSP
{
    //Testing the Liskov Substitution Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            EditableDocument editableDoc = new EditableDocument();
            editableDoc.Write("Editable Content");
            editableDoc.Read();

            ReadOnlyDocument readOnlyDoc = new ReadOnlyDocument("Read-Only Content");
            readOnlyDoc.Read();
            //readOnlyDoc.Write("Editable Content");
            Console.ReadKey();
        }
    }
}
