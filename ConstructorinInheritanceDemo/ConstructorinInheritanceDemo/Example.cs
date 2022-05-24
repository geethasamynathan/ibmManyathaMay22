using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorinInheritanceDemo
{
    internal class Exmaple
    {
        public Exmaple()
        {
            Console.WriteLine("I am default Constructor");
        }
        public Exmaple(int a)
        {
            Console.WriteLine( "I am the Constructor of Example"+a);
        }
        public void aa()
        {
            Console.WriteLine("I am aa from Example");
        }
    }
    internal class Sample:Exmaple

    {
        public Sample()
        {
            Console.WriteLine("I am the Constructor of Sample");
        }
        public Sample(int y)
        {
            Console.WriteLine(" i am parameterised ocnstructor in Sample");
        }
        public void bb()
        {
            Console.WriteLine("I am bb from Sample");
        }
    }
}
