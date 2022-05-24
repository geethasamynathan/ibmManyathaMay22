using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Enter the value of x between A-D");
            x = Console.ReadLine();

            switch (x.ToUpper())
            {
                case "A": Console.WriteLine("Apple"); break;
                case "B": Console.WriteLine("Banana"); break;
                case "C": Console.WriteLine("chiku"); break;
                case "D": Console.WriteLine("dog"); break;
                default: Console.WriteLine(" Invalid Entry"); break;
            }

            Console.ReadLine();
        }
    }
}
