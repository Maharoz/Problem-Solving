using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrisoner
{
    class Program
    {
        //https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem
        static void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            long[,] a = new long[n, 3];
            List<long> output = new List<long>();

            for (long i = 0; i < n; i++)
            {
                string[] x = Console.ReadLine().Split(' ');

                for (long j = 0; j <= 2; j++)
                {
                    a[i, j] = Convert.ToInt64(x[j]);
                }
            }

            output = prisoner(a);
            foreach (long i in output)
            {
                Console.WriteLine(i);
            }
        }

        static List<long> prisoner(long[,] a)
        {
            List<long> output = new List<long>();
            long numberOfPrisoner = 0;
            long numberOfCandy = 0;
            long startingPosition = 0;
            //int nextPrisonerToGetCandy = 0;


            for (long i = 0; i < a.GetLength(0); i++)
            {
              
                numberOfPrisoner = a[i, 0];
                numberOfCandy = a[i, 1];
                startingPosition = a[i, 2];

                var r = 
                    (numberOfCandy + startingPosition - 1) %
                    numberOfPrisoner;

                if (r == 0)
                    r = numberOfPrisoner;


                output.Add(r);
                 r = 0;


            }

            return output;
        }
    }
}
