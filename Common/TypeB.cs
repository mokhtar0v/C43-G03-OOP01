using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA obj = new TypeA();
            //obj.x = 10; invalid
            obj.y = 10; //valid
            obj.z = 20; //valid

        }
    }
}
