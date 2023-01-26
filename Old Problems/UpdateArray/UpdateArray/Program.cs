using System;
using System.Linq;

namespace UpdateArray
{
    class Program
    {
        static bool isgreater = false;
        static int count = 0;
        //problem url-->https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/micro-and-array-update/
        static void Main(string[] args)
        {
            int noOfCase = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < noOfCase; i++)
            {
                string[] a = Console.ReadLine().Split();
                int elementQty = Convert.ToInt32(a[0]);
                int sec = Convert.ToInt32(a[1]);

                int[] arr = new int[elementQty];
                string[] b = Console.ReadLine().Split();
                int[] myInts = Array.ConvertAll(b, s => int.Parse(s));

                for (int j = 0; j < elementQty; j++)
                {
                    arr[j] = myInts[j];
                }

                
                while (isgreater == false)
                {
                    isgreater = checkArray(arr, sec);
                    if (isgreater == false)
                    {
                        int[] newArr = arr.Select(p => p +1).ToArray();
                        arr = newArr;
                        count = count + 1;
                    }
                }

                Console.WriteLine(count);
                count = 0;
                isgreater = false;

            }
        }

        public static bool checkArray(int[] a,int num)
        {
            isgreater = a.All(x => x >= num);
            return isgreater;
        }
    }
}
