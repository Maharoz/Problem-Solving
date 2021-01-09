using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {

        //problem url-->https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        static void Main(string[] args)
        {
            int noOfCandle = Convert.ToInt32(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int[] convertedArr = Array.ConvertAll(arr, s => int.Parse(s));
            int max = convertedArr.Max();
            var result = convertedArr.Count(x => x == max);
            Console.WriteLine(result);

        }
    }
}
