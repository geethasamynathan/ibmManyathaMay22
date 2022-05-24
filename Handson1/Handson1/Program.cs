using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reg_no, subject1, subject2, subject3, subject4, subject5, total, average;
            string student_name, department,result,grade="";
            Console.WriteLine("enter the Registration Number, Name  and department of the Student");
            reg_no= Convert.ToInt32(Console.ReadLine());
            student_name = Console.ReadLine();
            department = Console.ReadLine();
            Console.WriteLine(" Enter 5 subject marks");
            subject1= Convert.ToInt32(Console.ReadLine());
            subject2 = Convert.ToInt32(Console.ReadLine()); 
            subject3 = Convert.ToInt32(Console.ReadLine());
            subject4 = Convert.ToInt32(Console.ReadLine());
            subject5 = Convert.ToInt32(Console.ReadLine());
            total= subject1+subject2+ subject3+ subject4+ subject5;
            average= total/5;
            if(subject1>=60 && subject2>=60 && subject3>=60 && subject4>=60 && subject5>=60)
            {
                result = "Pass";
                if(average>=90 && average<=100)
                {
                    grade = "Excellent";
                }
                else if(average>=80 && average<90)
                {
                    grade = "Very good";
                }
                else if(average>70 && average<=79)
                {
                    grade = "Good";

                }
                else if(average>=60 && average<70)
                {
                    grade = "Fair";
                }
                else
                {
                    grade = "None";
                }
            }
            else
            {
                result = "Fail";
            }

            Console.WriteLine("Student Details are\n ------------------------\n");
            Console.WriteLine($"Registrtion Number : {reg_no}\n" +
                $"Name = {student_name}\nDepartment = {department}\n" +
                $"Subject1 = {subject1}\nsubject2={subject2}\nsubject3={subject3}\n " +
                $"subject4={subject4}\n subject5 =" +
                $"{subject5}\n" +
                $"---------------\nTotal={total}\nResult= {result}\n ----------\n");
            if(grade!=null)
            {
                Console.WriteLine("Grade ="+grade);
            }
            Console.ReadLine();
        }
    }
}
