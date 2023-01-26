using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciPosition
{
    class Program
    {

        //Problem definition
        static void Main(string[] args)
        {
            int n = 9;
            Console.WriteLine(fib(n));
        }

        static int fib(int n)
        {
            int[] f = new int[n + 2];
            int i;

            f[0]=0;
            f[1] = 1;

            for (i = 2; i <= n; i++)
            {
                f[i] = f[i - 1] + f[i - 2];
            }

            return f[n];
        }
    }
}
