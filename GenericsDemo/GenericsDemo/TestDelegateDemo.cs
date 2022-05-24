using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public delegate T Numberchanger<T>(T val);
    internal class TestDelegateDemo
    {
       static int total = 10;
        public static int AddNum(int x)
        {
            total += x;
            return total;
        }
        public static int MultiplyNum(int x)
        {
            total *= x;
            return total;
        }
    }
}
