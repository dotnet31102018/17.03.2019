using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703Exc
{
    class Cook
    {

        public void HandleOrder(string dish)
        {
            Console.WriteLine($"Cook is handling {dish}");

            if (dish == "Humus")
            {
                //try
                //{
                //    if (Stock.Pitot == 0)
                //    {
                //        throw new OutOfPitotException("No more pitot!");
                //    }

                //    Stock.Pitot--;

                //    Console.WriteLine("One humus coming out!");
                //}
                //catch (OutOfPitotException e)
                //{
                //    // log to file ...
                //    Console.WriteLine(e);
                //    Console.WriteLine("Humus is coming out with no pita. with lafa");

                //    // inner exception
                //    //throw new Exception("general exception", e);
                //}

                if (Stock.Pitot == 0)
                {
                    throw new OutOfPitotException("No more pitot!");
                }

                Stock.Pitot--;

                Console.WriteLine("One humus coming out!");
            }
            else
            {
                Console.WriteLine($"{dish} is coming out!");
            }
        }
    }
}
