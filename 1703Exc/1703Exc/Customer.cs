using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703Exc
{
    class Customer
    {
        Waiter waiter = new Waiter();
        public void RequestDish(string dish)
        {
            waiter.GetOrder(dish);
        }
    }
}
