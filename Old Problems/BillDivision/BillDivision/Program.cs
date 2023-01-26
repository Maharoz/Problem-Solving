using System;
using System.Linq;

namespace BillDivision
{
    class Program
    {

        //Problem Url-->https://www.hackerrank.com/challenges/bon-appetit/problem
        static void Main(string[] args)
        {
            string[] initialInput = Console.ReadLine().Split();
            int noOfItem = Convert.ToInt32(initialInput[0]);
            int annaDidntEat = Convert.ToInt32(initialInput[1]);

            string[] item = Console.ReadLine().Split();
            int[] orderedItem = Array.ConvertAll(item, s => int.Parse(s));
            int annaPaid = Convert.ToInt32(Console.ReadLine());

            int annaHaveToPay = 0;

            for(int i = 0;i< orderedItem.Length; i++)
            {
                if(i!= annaDidntEat)
                {
                    annaHaveToPay = annaHaveToPay + orderedItem[i];
                }
            }
            annaHaveToPay = annaHaveToPay / 2;
            if (annaHaveToPay == annaPaid)
            {
                Console.WriteLine("Bon Appetit");
            }else if (annaPaid> annaHaveToPay)
            {
                Console.WriteLine(annaPaid- annaHaveToPay);
            }
        }
    }
}
