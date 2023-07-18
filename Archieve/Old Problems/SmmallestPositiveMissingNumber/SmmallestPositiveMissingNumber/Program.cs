using System;

namespace SmmallestPositiveMissingNumber
{

    //https://practice.geeksforgeeks.org/problems/smallest-positive-missing-number-1587115621/1?page=1&category[]=Searching&category[]=Stack&sortBy=submissions
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] arr = { 0, -10, 1, 3, -20 };
            int result = missingNumber(arr, n);
            Console.WriteLine(result);
        }

   

        //Function to find the smallest positive number missing from the array.
        public static int missingNumber(int[] arr, int n)
        {
            //code here
            int min = 1;
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                {
                    min++;
                }
            }
            return min;

        }
    }
}
