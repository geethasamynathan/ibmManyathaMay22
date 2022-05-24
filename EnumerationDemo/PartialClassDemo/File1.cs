using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    public partial class Customer
    {
    public string GetFullName()
        {
            return _firstname + " " + _lastname;
        }
    }

    internal class File1:Customer
    {
        public void aa()
        {
           
            Console.WriteLine(" aa from File1");
        }
    }
}
