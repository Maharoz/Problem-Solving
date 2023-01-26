using System;

namespace DPS001atm
{
    class Program
    {
        //Problem URL--> https://www.codechef.com/problems/HS08TEST
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int amountToBeWithDraw = Convert.ToInt32(input[0]);
            double totalBalance = Convert.ToDouble(input[1]);

            if(amountToBeWithDraw % 5 != 0)
            {
                Console.WriteLine(totalBalance.ToString("F2"));
               // return;
            }
            else if (amountToBeWithDraw> totalBalance)
            {
                Console.WriteLine(totalBalance.ToString("F2"));
            }
            else
            {
                double result = totalBalance - (amountToBeWithDraw + 0.5);
                Console.WriteLine(result.ToString("F2"));
            }
            
        }
    }
}
