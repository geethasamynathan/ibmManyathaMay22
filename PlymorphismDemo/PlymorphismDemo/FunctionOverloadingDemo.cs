using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlymorphismDemo
{
    internal class FunctionOverloadingDemo
    {
       
        public int  Add(int x, int y)
        {
           
            return (x + y);

        }
        public int Add(int x, int y, int z)
        {
            return (x + y+z);

        }
        public double Add(double  x, double y, int z)
        {
            double result = x + y + z;

            return result;

        }
    }
}
