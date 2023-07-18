using System;
using System.Collections.Generic;

namespace Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem link -->https://www.hackerrank.com/challenges/pairs/problem
            string a = Console.ReadLine();
            string[] initValue = a.Split(' ');
            int N = Convert.ToInt32(initValue[0]);
            int K = Convert.ToInt32(initValue[1]);
            string[] numberStrs = Console.ReadLine().Split(' ');
            List<int> number = new List<int>();

            foreach(string numberStr in numberStrs)
            {
                number.Add(Convert.ToInt32(numberStr));
            }

            number.Sort();
            int i = 0;
            int j = 0;
            int result = 0;

            while (i < number.Count)
            {
                int dist = number[i] - number[j];
                if (dist == K)
                {
                    result++;
                    i++;
                }
                if (dist < K)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            Console.WriteLine(result);

        }
    }
}
