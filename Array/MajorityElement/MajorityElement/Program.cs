﻿using System.Drawing;
using System.Net.NetworkInformation;

namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] a = { 3,1,3,3,2};
            majorityElement(a, 5);


        }
    
        public static int majorityElement(int[] a, int size)
        {
            /* Find the candidate for Majority*/
            int cand = findCandidate(a, size);

            /* Print the candidate if it is Majority*/
            if (isMajority(a, size, cand) == 1)
                return cand;
            else
                return -1;
        }
        public static int findCandidate(int[] a, int size)
            {
                int maj_index = 0, count = 1;

                // use linear search to compute candidate for majority element
                for (int i = 1; i < size; i++)
                {

                    if (a[maj_index] == a[i])
                        count++;
                    else
                        count--;
                    if (count == 0)
                    {
                        maj_index = i;
                        count = 1;
                    }
                }
                return a[maj_index];
            }


        /* Function to check if the candidate 
           occurs more than n/2 times */
        public static int isMajority(int[] a, int size, int cand)
        {
            int count = 0;
            for (int i = 0; i < size; i++)
                if (a[i] == cand)
                    count++;

            if (count > size / 2)
                return 1;

            else
                return 0;
        }

    }
}
