using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLineJumps
{
    class Program
    {

        //Problem URL-->https://www.hackerrank.com/challenges/kangaroo/problem
        static void Main(string[] args)
        {
            var tokens_x1 = Console.ReadLine().Split(' ');
            var x1 = Convert.ToInt32(tokens_x1[0]);
            var v1 = Convert.ToInt32(tokens_x1[1]);
            var x2 = Convert.ToInt32(tokens_x1[2]);
            var v2 = Convert.ToInt32(tokens_x1[3]);
            var result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            var sameLocationPossible = "";
            if (x1 < x2 && v1 < v2)
                sameLocationPossible = "NO";

            else if (x2 < x1 && v2 < v1)
                sameLocationPossible = "NO";

            else if (x2 < x1)
            {
                var numberOfJumps = ((double)(x1 - x2)) / (v2 - v1);
                if (numberOfJumps % 1 == 0)
                    sameLocationPossible = "YES";
                else
                    sameLocationPossible = "NO";
            }
            else
            {
                var numberOfJumps = ((double)(x2 - x1)) / (v1 - v2);
                if (numberOfJumps % 1 == 0)
                    sameLocationPossible = "YES";
                else
                    sameLocationPossible = "NO";
            }
            return sameLocationPossible;
        }
    }
}
