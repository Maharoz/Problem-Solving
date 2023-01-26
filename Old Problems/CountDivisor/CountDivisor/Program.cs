using System;

namespace CountDivisor
{
    class Program
    {

        //problem url -->https://www.hackerearth.com/practice/basic-programming/input-output/basics-of-input-output/practice-problems/algorithm/count-divisors/
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();
            int n1 = Convert.ToInt32(a[0]);
            int n2 = Convert.ToInt32(a[1]);
            int n3 = Convert.ToInt32(a[2]);
            int count=0;

            for(int i = n1; i<= n2; i++)
            {
                if(i%n3 == 0)
                {
                    count++;
                    
                }
            }
            Console.WriteLine(count);
        }
    }
}
