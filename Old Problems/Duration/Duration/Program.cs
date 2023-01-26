using System;

namespace Duration
{
    class Program
    {
        //Problem link-->https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/duration/
        static void Main(string[] args)
        {
            int noOfInput,a=0,b=0;
            noOfInput = Convert.ToInt32(Console.ReadLine());
           

            for(int i = 0; i < noOfInput; i++)
            {
                string[] input = Console.ReadLine().Split();
                int min1 = Convert.ToInt32(input[0]) * 60 + Convert.ToInt32(input[1]);
                int min2 = Convert.ToInt32(input[2]) * 60 + Convert.ToInt32(input[3]);
                min2 -= min1;
                int hours = min2 / 60;
               int min = min2 % 60;
                Console.WriteLine(hours + " " + min);
            }




        }
    }
}
