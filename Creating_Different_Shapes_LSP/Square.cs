using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Different_Shapes_LSP
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
}
