using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {

        //Problem URL-->https://www.hackerrank.com/challenges/a-very-big-sum/submissions/code/123496869
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c = Console.ReadLine().Split(' ');
            long result = 0;
            var ar = Array.ConvertAll(c, long.Parse);

            for (int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }
            Console.WriteLine(result);
        }
    }
}
