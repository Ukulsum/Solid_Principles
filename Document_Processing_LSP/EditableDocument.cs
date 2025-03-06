using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Processing_LSP
{
    public class EditableDocument : IReadable, IWritable
    {
        public string Content { get; set; }
        public void Read()
        {
            Console.WriteLine(Content);
        }

        public void Write(string content)
        {
            Content = content;
        }
    }
}
