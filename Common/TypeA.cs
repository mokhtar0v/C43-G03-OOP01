using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // What we can write inside the namespace
    //1-Class
    //2-Struct
    //3-Interface
    //4-Enum
    //Allowed Access modifiers inside namespace
    //1-internal(default)
    //2-public
    public class TypeA
    {
        #region Definitions
        //What u can write inside the class or struct
        //1- Attributes
        //2- Property
        //3- Functions (constructor - getter,setter - method)
        //4- Event

        //Allowed access modifiers inside the struct is 
        //1-Private
        //2-Private internal
        //3-Public

        //Allowed access modifiers inside th class is
        //1-Private
        //2-Private protected
        //3-Protected\
        //4-Internal
        //5-Internal protected
        //6-Public

        //What u can write inside interface
        //1-Signature for property
        //2-Signature for method
        //3-Default implemented method

        //Default access modifier in interface is public

        #endregion
        //private is default access modifier
        private int x;
        internal int y;
        public int z;


    }
}
