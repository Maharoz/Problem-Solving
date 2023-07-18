using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDays
{
    class Program
    {
        //https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem

        static void Main(string[] args)
        {
            string[] c = Console.ReadLine().Split(' ');
            long startRange = Convert.ToInt64(c[0]);
            long endRange = Convert.ToInt64(c[1]);
            long divisor = Convert.ToInt64(c[2]);
            long x = reverseNumber(startRange,endRange, divisor);
            Console.WriteLine(x);
        }


        static long reverseNumber(long startRange, long endRange, long divisor)
        {
            long count = 0;
            long reverse = 0;
         

            for(long i = startRange; i<= endRange; i++)
            {

                reverse = makeReverse(startRange);
                if ((startRange - reverse) % divisor == 0)
                {
                    count++;
                }
                startRange++;
            }
         

           return count;
        }

        static long makeReverse(long num)
        {
            long reverse = 0;
            while (num > 0)
            {

                long remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
            }

            return reverse;
        }
    }
}
