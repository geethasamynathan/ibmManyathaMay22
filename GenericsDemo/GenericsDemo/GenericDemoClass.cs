using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenericDemoClass<T1, T2>
    {
       
            T1 a;
            T2 b;
            public GenericDemoClass(T1 a, T2 b)
            {
                this.a = a;
                this.b = b;
            }
         public   void Display()
            {
                Console.WriteLine($" a= {this.a} \t b ={this.b}");
            }
        
    }
}
