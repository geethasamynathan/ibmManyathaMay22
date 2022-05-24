using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{

    public delegate double AddNumbersDelegate(int num1, float num2, double num3);
    public delegate void AddNumbersDelegate2(int num1, float num2, double num3);
    public delegate bool CheckStringLength(string str);
    internal class DelegateTypes
    {
        public static double AddNumbers(int num1, float num2, double num3)
        {
            return num1 + num2 + num3;
        }
        public static void AddNumbersResult(int num1, float num2, double num3)
        {
            Console.WriteLine(  "Sum of given values are ="+( num1 + num2 + num3));
        }
        public static bool CheckLength(string name)
        {
            if(name.Length>5)
            {
                return true;
            }
            else
                return false;

        }
    }
}
