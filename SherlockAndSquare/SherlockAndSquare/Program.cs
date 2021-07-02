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

            int n = Convert.ToInt32(Console.ReadLine());
            string[] c = Console.ReadLine().Split(' ');
            int[] a = new int[c.Length];

            for (int i = 0; i < c.Length; i++)
            {
                a[i] = Convert.ToInt32(c[i]);
            }

            Console.WriteLine(checkSquare(a));
        }

        static int checkSquare(int[] a)
        {
            int startingNumber = a[0];
            int endingNumber = a[1];
            int count = 0;

            for(int i=startingNumber;i<= endingNumber; i++)
            {
                double sq = Math.Sqrt(i);
                int x = Convert.ToInt32(Math.Truncate(sq));
                if (x * x == i)
                {
                    count = count + 1;
                }
            }

            return count;
        }
    }
}
