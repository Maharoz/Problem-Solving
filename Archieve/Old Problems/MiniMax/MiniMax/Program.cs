using System;
using System.Linq;

namespace MiniMax
{
    class Program
    {
        //problem URL-->https://www.hackerrank.com/challenges/mini-max-sum/problem
        static void Main(string[] args)
        {

            long[] input = new long[5];
            string[] arrayVal = Console.ReadLine().Split();
            long[] mylongs = Array.ConvertAll(arrayVal, s => long.Parse(s));
            long smallestSum=0, bisggestSum=0;

            for (long i = 0; i < input.Length; i++)
            {
                input[i] = mylongs[i];
            }

            long max = input.Max();
            long min = input.Min();

            if (min == max)
            {
                bisggestSum = min * 4;
                smallestSum = max * 4;
            }
            else
            {
                for (long j = 0; j < input.Length; j++)
                {
                    if (input[j] != max)
                    {
                        bisggestSum = bisggestSum + input[j];
                    }
                    if (input[j] != min)
                    {
                        smallestSum = smallestSum + input[j];
                    }
                }
            }

            Console.WriteLine(bisggestSum + " " + smallestSum);
        }
    }
}
