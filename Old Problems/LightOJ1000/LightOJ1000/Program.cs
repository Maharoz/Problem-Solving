using System;

namespace LightOJ1000
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problem URL https://lightoj.com/problem/greetings-from-lightoj
            int n, i = 1, x, y;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < n +1; i++)
            {
                string[] number = Console.ReadLine().Split();
                int total = Convert.ToInt32(number[0]) + Convert.ToInt32(number[1]);
                Console.WriteLine(" Case " + i +":"+ total);
                
            }
        }
    }
}
