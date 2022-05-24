using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemoFramework
{
    internal class OutparamDemo
    {
        //static int  Addition(int a, int b)
        //{
        //    int addresult, subresult;
        //    addresult = a + b;
        //    subresult = a - b;
        //    return addresult,subresult;
        //}
        //static void Calculate(int a, int b, out int sum, out int diff, out int multiply)
        //{
        //    sum = a + b;
        //    diff = a - b;
        //    multiply = a * b;
        //}

        //static void Main(string[] args)
        //{
            
        //    Calculate(100, 40, out int sum1, out int diff, out int multpiy);
        //    Console.WriteLine($"sum = {sum1} \n difference = {diff} \n Multiplication = {multpiy}");
        //    Console.ReadLine();
        //}

        //example for optional parameter with default value

        //static void GetEmployeeDetail(int id, string  Name, int salary=20000)
        //{
        //    Console.WriteLine($" Id= {id}\n Name={Name}\n salary={salary}");
        //}
        //static void Main(string[] args)
        //{
        //    GetEmployeeDetail(101, "Geetha");
        //    GetEmployeeDetail(102, "Fransy", 450000);
        //    Console.ReadLine();
        //}

        static int SunofParameters(params int [] valules)
        {
            int total = 0;
            foreach (var item in valules)
            {
                total += item;
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Sum of values is "+SunofParameters(1));
            Console.WriteLine(" Sum of values is " + SunofParameters(1,6,3,67));
            Console.WriteLine(" Sum of values is " + SunofParameters(4,2,5));
            Console.WriteLine(" Sum of values is " + SunofParameters(10,20,30,40));
            Console.ReadLine();
        }
    }
}
