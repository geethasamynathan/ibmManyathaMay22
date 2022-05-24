using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectConceptDemo
{
    internal class Employee
    {
        int employeeid,salary;
        string name, designation;

         void GetemployeeInfo()
        {
            Console.WriteLine(" Enter the EMpoyee Id,Name , Designation and Salary");
            employeeid=Convert.ToInt32(Console.ReadLine());
            name=Console.ReadLine();
            designation=Console.ReadLine();
            salary=Convert.ToInt32(Console.ReadLine());
                
        }

        public void printEmployeeInfo()
        {
            GetemployeeInfo();
            Console.WriteLine(" Employee Details are ");
            Console.WriteLine($" Id :{employeeid}\n Name ={name} \n Designation ={designation}\n Salary={salary}");
        }
    }
}
