using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    internal class Loopdemo
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <5; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int x = 90;
            //while(x>85)
            //{
            //    Console.WriteLine(x);
            //    x--;
            //}

            int x = 900;
            do
            {
                Console.WriteLine(x);
                x++;

            } while (x <= 910);


            Console.ReadLine();
        }
    }
}
