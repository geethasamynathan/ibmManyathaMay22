using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void MyDelegate(int a, int b);
    delegate void PrintDelegate();
    internal class SampleDelegateDemo
    {
        public void printMessage()
        {
            Console.WriteLine(" I am printing a message");
        }
        public void Add(int x,int y)
        {
            Console.WriteLine(" addition of given values are"+(x+y));
        }
        public void Difference(int x, int y)
        {
            Console.WriteLine(" Difference  of given values are" + (x -y));
        }
    }
}
