using System;

namespace LOJ1022
{
    class Program
    {
        //problem url https://lightoj.com/problem/circle-in-square
        static void Main(string[] args)
        {
            int i = 1, n;
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i < n + 1; i++)
            {
                double radius = Convert.ToDouble(Console.ReadLine());
                double areaOfSquare = (radius + radius)* (radius + radius);
                double areOfCircle = 3.1416 *( radius* radius);
                double shadedArea = areaOfSquare - areOfCircle;
                double result = Math.Round(shadedArea, 2);
                Console.WriteLine("Case" + i +":"+ result);
            }
        }
    }
}
