using System;
using System.Linq;

namespace Toggle_String
{
    class Program
    {
        // problem URL https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/modify-the-string/
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string toggled = new string(input.Select(c => (char)
            (c > 64 && c < 91 ? c + 32 : 
            (c > 96 && c < 123 ? c - 32 : c))).ToArray());
            Console.WriteLine(toggled);
        }
    }
}
