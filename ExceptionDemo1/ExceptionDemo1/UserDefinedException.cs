using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo1
{
    internal class UserDefinedException
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the age of an Employee");
            age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if(age<20  || age>=70)
                {
                    throw new Exception("Age should between 21 to 70");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
    }
    }
       
}
