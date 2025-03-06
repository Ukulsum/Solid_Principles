using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Document_Processing_LSP
{
    public interface IWritable
    {
        string Content { get; set; }
        void Write(string content);
    }
}
