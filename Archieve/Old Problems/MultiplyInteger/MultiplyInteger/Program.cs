using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyInteger
{
    //Given an array of integers, return a new array such that each element at 
    //index i of the new array is the product of all the numbers in the 
    //original array except the one at i

    //For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c = Console.ReadLine().Split();
            int[] intArray = new int[n];
            int[] tempArray = new int[n-1];
            int[] finalArray = new int[n];
            int temEl = 1;

            for(int i = 0; i < c.Length; i++)
            {
                intArray[i] = Convert.ToInt32(c[i]);
            }

            for (int i = 0; i < intArray.Length; i++)
            {
                tempArray = intArray.Where(val => val != intArray[i]).ToArray();
                
                foreach(int value in tempArray)
                {
                    temEl *= value;
                }

                finalArray[i] = temEl;
                temEl = 1;
            }

            for (int i = 0; i < finalArray.Length; i++)
            {
                Console.WriteLine(finalArray[i]);
            }


        }
    }
}
