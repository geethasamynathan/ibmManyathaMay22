using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDemo
{
    internal class Sample
    {
      public  int y;
        public Sample()
        {
            Console.WriteLine(" I am Default (or) parameterless Constructor");
        }
        public Sample(int x)
        {
            Console.WriteLine(" I am parameterised Constructor"+x);
        }
         public void aa()
        {
            Console.WriteLine(" I am from Sample class");
        }
        public Sample(Sample s1)
        {
            this.y = s1.y;
            Console.WriteLine("I am Cory constructor. y value is = "+y);
        }
    }
}
