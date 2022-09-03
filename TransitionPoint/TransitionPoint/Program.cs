using System;
using System.Linq;

namespace TransitionPoint
{

    //https://practice.geeksforgeeks.org/problems/find-transition-point-1587115620/1?page=1&difficulty[]=0&category[]=Searching&category[]=Stack&sortBy=submissions
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int[] arr = { 0, 0, 0, 1, 1 };
            transitionPoints( arr,n);
        }
        public static int transitionPoints(int[] arr, int n)
        {
            // code here

            int mid = n / 2;
            if (arr[mid] == 0)
            {
                for (int i = mid + 1; i < n; i++)
                {
                    if (arr[i] == 1)
                    {
                        return i;
                    }
                }
            }
            else if (arr[mid] == 1)
            {
                for (int i = 0; i <= mid; i++)
                {
                    if (arr[i] == 1)
                    {
                        return i;
                    }
                }
            }
            else
            {
                return -1;
            }

            return -1;

        }
    }

  
}
