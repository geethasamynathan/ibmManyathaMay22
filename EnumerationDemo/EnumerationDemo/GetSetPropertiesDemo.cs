using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationDemo
{
    public class Employee
    {
        int salary = 9000;
        public int Empid { get; set; }
        public string Name { get; set; }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }

        }
    }

    //write only property ==> set
    //readonly property ==> get
    //read and write ==>get and set

    internal class GetSetPropertiesDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Empid = 101;
            emp.Name = "Peter";
            emp.Salary = 120000;
            Console.WriteLine($"{emp.Empid} \n {emp.Name} \t {emp.Salary}");
        }
    }
}
