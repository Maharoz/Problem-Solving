using System;

namespace LightOJ1001
{
    class Program
    {

        //Problem url https://lightoj.com/problem/opposite-task
        static void Main(string[] args)
        {
            int i = 0, n;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 10)
                {
                    Console.WriteLine( 0+ " " +number);
                }
                else
                {
                    Console.WriteLine(10 + " " + (number-10));
                }
            }
        }
    }
}
