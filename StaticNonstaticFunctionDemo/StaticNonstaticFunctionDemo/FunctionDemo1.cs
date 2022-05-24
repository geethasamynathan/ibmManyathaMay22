using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNonstaticFunctionDemo
{
    internal class FunctionDemo1
    {
        public void Method1()
        {
            Console.WriteLine(" I am Method1 from FunctionDemo1 class. I am Non static Function");
        }
        public static  void Method2()
        {
            Console.WriteLine(" I am Method2 from FunctionDemo1 class. I am a static Function");
        }
    }
}
