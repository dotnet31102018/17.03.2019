using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1703HW
{

    class MyProtectedUniqueList : IEnumerable<string>
    {

        private List<string> words;
        private string password;

        public MyProtectedUniqueList(string password)
        {
            words = new List<string>();
            this.password = password;
        }

        public void Add(string item)
        {
            if (item == null || item == string.Empty)
            {
                throw new ArgumentNullException("string is empty/null");
            }

            if (words.Contains(item))
                throw new InvalidOperationException($"{item} already exists!");

            words.Add(item);
        }
        public void Remove(string item)
        {
            if (item == null || item == string.Empty)
            {
                throw new ArgumentNullException("string is empty/null");
            }

            if (!words.Contains(item))
                throw new InvalidOperationException($"{item} does not exist!");

            words.Remove(item);
        }

        public void RemoveAt(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException
                    ($"{index} cannot be negative! dah");
            }

            if  (index >= words.Count)
            {
                throw new IndexOutOfRangeException
                    ($"{index} is bigger than list size {words.Count}");
            }

            words.RemoveAt(index);
        }

        public void Clear(string password)
        {
            if (this.password != password)
            {
                throw new 
                    AccessViolationException($"{password} is not the correct password. Hacker!!");
            }
            else
            {
                words.Clear();
            }
        }

        public void Sort(string password)
        {
            if (this.password != password)
            {
                throw new
                    AccessViolationException($"{password} is not the correct password. Hacker!!");
            }
            else
            {
                words.Sort();
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return words.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return words.GetEnumerator();
        }

        public override string ToString()
        {
            string result = $"List values {words.Count} ";

            foreach (string s in words)
            {
                result += $"\n{s}";
            }

            return result;
        }
    }
}
