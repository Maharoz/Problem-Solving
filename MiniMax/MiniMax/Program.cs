using System;
using System.Linq;

namespace MiniMax
{
    class Program
    {
        //problem URL-->https://www.hackerrank.com/challenges/mini-max-sum/problem
        static void Main(string[] args)
        {

            int[] input = new int[5];
            string[] arrayVal = Console.ReadLine().Split();
            int[] myInts = Array.ConvertAll(arrayVal, s => int.Parse(s));
            int smallestSum=0, bisggestSum=0;

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = myInts[i];
            }

            int max = input.Max();
            int min = input.Min();

            for(int j =0;j< input.Length; j++)
            {
                if (input[j] != max)
                {
                    bisggestSum = bisggestSum + input[j];
                }
                if(input[j] != min)
                {
                    smallestSum = smallestSum + input[j];
                }
            }

            Console.WriteLine(bisggestSum + " " + smallestSum);
        }
    }
}
