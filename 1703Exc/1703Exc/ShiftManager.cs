using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703Exc
{
    class ShiftManager
    {
        Cook cook = new Cook();
        public void GetOrder(string dish)
        {

            //try
            //{
            //    Console.WriteLine($"ShiftManager is passing order ${dish}");
            //    cook.HandleOrder(dish);
            //}
            //catch (OutOfPitotException e)
            //{
            //    Console.WriteLine($"Shift manager saw no more Pitot. giving away free shwarma!");
            //}

            Console.WriteLine($"ShiftManager is passing order ${dish}");
            cook.HandleOrder(dish);
        }
    }
}
