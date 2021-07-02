using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndSquare
{
    class Program
    {

        //Problem link-->https://www.hackerrank.com/challenges/sherlock-and-squares/problem?fbclid=IwAR0GolVWc-BdNjRRk9aMWswywBxcN_5Zw2HeMSoy7f5-JQ1Pztd6EFbNa_4
        static void Main(string[] args)
        {

            long n = Convert.ToInt64(Console.ReadLine());
            long[,] a = new long[n, 2];
            List<long> output = new List<long>();

            for (long i = 0; i < n; i++)
            {
                string[] x = Console.ReadLine().Split(' ');

                for (long j = 0; j <= 1; j++)
                {
                    a[i, j] = Convert.ToInt64(x[j]);
                }
            }


            output = checkSquare(a);
            foreach (long i in output)
            {
                Console.WriteLine(i);
            }
        }

        static List<long> checkSquare(long[,] a)
        {


            List<long> output = new List<long>();
            long startingNumber = 0;
            long endingNumber = 0;
            long count = 0;
            long y = a.GetLength(0);

            for (long i = 0; i < a.GetLength(0); i++)
            {
                startingNumber = a[i, 0];
                endingNumber = a[i, 1];

                for (long j = startingNumber; j <= endingNumber; j++)
                {
                    double sq = Math.Sqrt(j);
                    long x = Convert.ToInt64(Math.Truncate(sq));
                    if (x * x == j)
                    {
                        count = count + 1;
                    }
                }
                output.Add(count);
                count = 0;
            }

            return output;
        }
    }
}
