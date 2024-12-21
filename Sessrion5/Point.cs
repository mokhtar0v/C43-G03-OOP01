using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessrion5
{
    internal struct Point
    {
        //Attributes
        public int x; public int y;
        public Point()
        {
            x = 0; y = 0;
        }
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
        //method
        public override string ToString()
        {
            return $"X = {x}, and Y = {y}";
        }
    }
}
