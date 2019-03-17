using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703Exc
{
    class Waiter
    {
        ShiftManager sm = new ShiftManager();
        public void GetOrder(string dish)
        {
            try
            {
                Console.WriteLine($"waiter is passing order ${dish}");
                sm.GetOrder(dish);
            }
            catch (OutOfPitotException e)
            {
                throw new DishNotValidException("sorry dish cannot come out!", e);
            }

            // calculating bill
            int a, b;
            a = b = 0;
            int bill = (a * 2) / b; // oops waiter divided by zeo...

        }
    }
}
