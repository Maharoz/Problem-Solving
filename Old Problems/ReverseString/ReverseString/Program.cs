using System;
using System.Collections;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcd";
            StringReverse r = new StringReverse();
            string result = r.reverse(str);

            Console.WriteLine(result);
        }
    }

    public class StringReverse
    {
        public string reverse(string input)
        {
            Stack MyStack = new Stack();

            foreach(char a in input)
            {
                MyStack.Push(a);
            }

            string reversed = string.Empty;

            while (MyStack.Count != 0)
            {
                reversed += MyStack.Pop();
            }

            return reversed;
        }
    }
}
