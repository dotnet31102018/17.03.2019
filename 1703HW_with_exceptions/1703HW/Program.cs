using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703HW
{
    class Program
    {
        static void Main(string[] args)
        {

            MyProtectedUniqueList list = new MyProtectedUniqueList("12345");
            try
            {
                list.Add(null);
            }
            catch (StringEmptyException e) when (e.Word == null)
            {
                Console.WriteLine("word was null");
            }
            catch (StringEmptyException e) when (e.Word == string.Empty)
            {
                Console.WriteLine("word was empty!");
            }

            try
            {
                list.Add("");
            }
            // catch clause
            catch (StringEmptyException e) when (e.Word == null)
            {
                Console.WriteLine("word was null");
            }
            catch (StringEmptyException e) when (e.Word == string.Empty)
            {
                Console.WriteLine("word was empty!");
            }

            return;

            list.Add("hello");
            list.Add("C#");
            list.Add(".NET");
            try
            {
                list.Remove("Java");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            catch(Exception e )
            {
                Console.WriteLine("Unknown " + e);

            }
            finally
            {
                Console.WriteLine("Finally here!");
            }

            Console.WriteLine(list);

            MyProtectedUniqueListGeneric<int> listNumbers = new MyProtectedUniqueListGeneric<int>("12345");
            listNumbers.Add(1);
            listNumbers.Add(2);
            listNumbers.Add(3);
            try
            {
                listNumbers.Add(1);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown " + e);

            }

            Console.WriteLine(listNumbers);
        }
    }
}
