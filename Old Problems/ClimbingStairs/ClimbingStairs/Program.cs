using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClimbingStairs
{
    class Program
    {

        //Problem URL-->https://leetcode.com/problems/climbing-stairs/solution/
        static void Main(string[] args)
        {
            int s = 4, m = 2;
            Console.Write("Number of ways = "
                          + countWays(s, m));


        }
        static int countWaysUtil(int n, int m)
        {
            if (n <= 1)
                return n;
            int res = 0;

            for (int i = 1; i <= m && i <= n; i++)
                res += countWaysUtil(n - i, m);
            return res;
        }

        // Returns number of ways to reach
        // s'th stair
        static int countWays(int s, int m)
        {
            return countWaysUtil(s + 1, m);
        }


    }
}
