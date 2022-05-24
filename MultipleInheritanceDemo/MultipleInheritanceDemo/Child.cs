using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceDemo
{
   interface IParent1
    {    
        //concrete mehtod
     void Method1()
        {
            Console.WriteLine("Method 1 from parent 1 ");
        }
        //abstract method
      void aa();            
     }
    interface IParent2
    {
        void Method2()
        {
            Console.WriteLine("Method 2 from parent 2 ");
        }
        void bb();
    }
    internal class Child:IParent1,IParent2
    {
        public void aa()
        {
            Console.WriteLine(" aa from Parent1 interface definition given in child class");
        }
        public void bb()
        {
            Console.WriteLine(" bb from Parent2 interface definition given in child class");
        }
        public void cc()
        {
           // Method1();
            Console.WriteLine(" i am cc from Child class");
        }
    }
}
