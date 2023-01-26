using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormALargestNumber
{
    class Program
    {

        //Create largest number from given array
        static void findMaxNum(int[] arr , int n)
        {
            int[] hash = new int[10];


            for(int i = 0; i < n; i++)
            {
                hash[arr[i]]++;

            }

            for (int i = 9; i >= 0; i--)
            {
                // Print the number of
                // times a digits occurs
                for (int j = 0; j < hash[i]; j++)
                    Console.Write(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 9, 3, 8, 5, 9};

            int n = arr.Length;

            findMaxNum(arr, n);
        }
    }
}
