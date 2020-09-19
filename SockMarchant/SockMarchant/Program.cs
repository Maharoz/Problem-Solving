using System;
using System.Linq;

namespace SockMarchant
{
    class Program
    {
        static void Main(string[] args)
        {

            //problem link-->https://www.hackerrank.com/challenges/sock-merchant/problem
            int n = int.Parse(Console.ReadLine());
            string[] c = Console.ReadLine().Split(' ');
            int result = 0;
            foreach(string color in c.Distinct())
            {
                result += c.Where(ci => ci == color).Count() / 2;
            }
            Console.WriteLine(result);
        }
    }
}
