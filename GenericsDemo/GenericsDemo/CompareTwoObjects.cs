using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class CompareTwoObjects
    {
        public bool AreEqual<Type1>(Type1 val1, Type1 val2)
        {
            return val1.Equals(val2);
        }
       
    }
}
