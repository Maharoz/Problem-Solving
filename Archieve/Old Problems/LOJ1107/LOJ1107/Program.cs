using System;

namespace LOJ1107
{
    class Program
    {

        //Problem URL https://lightoj.com/problem/how-cow
        static void Main(string[] args)
        {
            int noOfCase, n;
            string[] number = Console.ReadLine().Split();
            int lowerX = Convert.ToInt32(number[0]);
            int lowerY = Convert.ToInt32(number[1]);
            int upperX = Convert.ToInt32(number[2]);
            int upperY = Convert.ToInt32(number[3]);
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                string[] cowPosition = Console.ReadLine().Split();
                int cowX = Convert.ToInt32(cowPosition[0]);
                int cowY = Convert.ToInt32(cowPosition[1]);
                if(cowX<lowerX ||cowX>upperX || cowY< lowerY|| cowY > upperY)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }

            }
    }
}
