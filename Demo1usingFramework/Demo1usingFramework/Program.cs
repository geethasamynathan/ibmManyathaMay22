using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1usingFramework
{
    internal class Program
    {
        static void Main(string[] args)
        //{//variable declaration
        //    int num1, num2, total;
        //    // initializing variables
        //    num1 = 89; num2 = 900;
        //    total = num1 + num2;
        //    Console.WriteLine("Num1 =" + num1 + "\n num2=" + num2 + "\n Total=" + total);
        //    Console.WriteLine("Num1 ={0} \n Num2={1}\n Totla={2}", num1, num2, total);
        //    Console.WriteLine($"Num1= {num1} \n Num2= {num2} \n Total={total}");
        //    Console.WriteLine("Hello, welcome to .net Framework");
        //    }

        //{
        //    int a = 900;
        //    float b = 56.34f;
        //    double c = 68.3243534;
        //    char d= 'O';
        //    string s = "Geetha";
        //    Console.WriteLine($"a ={a} \n float value ={b}\n double ={c} \n character ={d}\n String value ={s}");
        //}


        {
            int a;
            float b;
            double c;
            char d;
            string e;
            Console.WriteLine(" before initializing the variable values are");
           // Console.WriteLine($"a= {a}\n b={b}\n c={c}\nd={d}\n e={e}");
            Console.WriteLine(" enter the integer value for a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the float value");
            b= float.Parse(Console.ReadLine());
            Console.WriteLine("Ente the double value");
            c= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" enter the character");
            d=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter the string ");
            e= Console.ReadLine();
            Console.WriteLine($"a= {a}\n b={b}\n c={c}\nd={d}\n e={e}" );
            Console.WriteLine("a= "+a+"\n b="+b+"\n c="+c+"\nd="+d+"\n e="+e);
            Console.ReadLine();
        }
    }
}
