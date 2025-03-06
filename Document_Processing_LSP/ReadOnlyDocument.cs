using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Processing_LSP
{
    public class ReadOnlyDocument : IReadable
    {
        public ReadOnlyDocument(string content)
        {
            Content = content;
        }
        public string Content { get; }

        public void Read()
        {
            Console.WriteLine(Content);
        }
    }
}
