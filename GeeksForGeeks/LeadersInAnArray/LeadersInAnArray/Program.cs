using System;
using System.Collections.Generic;

namespace LeadersInAnArray
{
    internal class Program
    {

        //https://practice.geeksforgeeks.org/problems/leaders-in-an-array-1587115620/1?page=1&difficulty[]=0&category[]=Arrays&sortBy=submissions
        static void Main(string[] args)
        {
            int n = 6;
            int[] input = { 16, 17, 4, 3, 5, 2 };
            int[] output = new int[input.Length];
            int x = 0;

            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j <= input.Length-1; j++)
                {
                    if(input[i] < input[j])
                    {
                        break;
                    }
                    else if(j== input.Length-1)
                    {
                        output[x] = input[i];
                        x++;
                    }
                }
            }
            output[x] = input[input.Length - 1];

            int[] outputNew = new int[x];
            outputNew = output;

            for (int i = 0; i < output.Length; i++)
            {
               if (output[i] != 0)
              {
                    outputNew[i] = output[i];
                    Console.WriteLine(outputNew[i]);
               }
                
            }
        }
    }
}
