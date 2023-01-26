using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{

    //https://leetcode.com/problems/container-with-most-water/
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 4, 3 };

            int len1 = 4;
            Console.WriteLine(maxArea(a, len1));

        }

        public static int maxArea(int[] A,int len)
        {
            int l = 0;
            int r = len - 1;
            int area = 0;

            while (l < r)
            {
                area = Math.Max(area, Math.Min(A[l], A[r]) * (r - l));

                if (A[l] < A[r])
                    l += 1;

                else
                    r -= 1;
            }
            return area;
        }
      

    }
}
