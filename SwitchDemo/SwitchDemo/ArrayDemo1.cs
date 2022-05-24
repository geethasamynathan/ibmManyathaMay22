using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchDemo
{
    internal class ArrayDemo1
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[5];
            Console.WriteLine("enter 5 integer values ");
            for (int i = 0; i < 5; i++)
            {
                myarray[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine(" Array Elements are ");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(myarray[i]);
            }

            Console.WriteLine(" Length (or) size of an Array " + myarray.Length);
            Array.Reverse(myarray);

            Console.WriteLine("After reversing  Array Elements are ");
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }

            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
