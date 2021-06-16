using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace StairCase
{
    class Program
    {
        //Problem URL-->https://www.hackerrank.com/challenges/staircase/submissions/code/123555606
        static void Main(string[] args)
        {
            var n = int.Parse(ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ', n - i);
                var hashes = new String('#', i);
                WriteLine(spaces + hashes);

            }

        }
    }
}
