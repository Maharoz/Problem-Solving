using System;

namespace SolveMeFirst
{
    class Program
    {
       
            //Problem Link -->https://www.hackerrank.com/challenges/solve-me-first/problem

             static int solveMeFirst(int a, int b)
            {
                return a + b;
            }
            static void Main(string[] args)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(solveMeFirst(a, b));

           
        }
    }
}
