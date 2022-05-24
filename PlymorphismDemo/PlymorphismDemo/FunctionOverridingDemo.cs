using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlymorphismDemo
{
  public class FunctionOverridingDemo
    {
        public virtual void aa()
        {
            Console.WriteLine("Definition of aa from Base class");
        }
    }
    class Sample : FunctionOverridingDemo
    {
      public override void aa()
        {
           base.aa();
            Console.WriteLine("Aa from Derived class");
        }
    }

}
