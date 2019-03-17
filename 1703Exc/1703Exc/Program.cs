using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703Exc
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            try
            {
                c.RequestDish("Humus");
                c.RequestDish("Humus");
                c.RequestDish("Humus");
            }
            catch (DishNotValidException e)
            {
                Console.WriteLine("Dish not valid ... bommer. i will order something else...");
            }
            catch (SystemException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
