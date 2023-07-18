using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        //Problem URL --> https://www.hackerrank.com/challenges/simple-array-sum/problem
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c = Console.ReadLine().Split(' ');

            int result = 0;
            foreach (var item in c)
            {
                result += Convert.ToInt32(item);
            }

            Console.WriteLine(result);
        }
    }
}
