using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            if (a == 0)
            {
                Console.WriteLine("calculator does not like zero");
                return 0;
            }
            return a + b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                return 0;
            return a / b;
        }
    }
}
