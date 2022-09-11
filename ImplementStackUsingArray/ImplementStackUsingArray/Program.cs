
using System;

namespace ImplementStackUsingArray
{

    //https://practice.geeksforgeeks.org/problems/implement-stack-using-array/1?page=1&category[]=Stack&sortBy=submissions
    class Program
    {
        static void Main(string[] args)
        {
            string op = Console.ReadLine();
        }
    }


    class MyStack
    {
        //Complete this function
        int[] arr = { };
        int i = 0;
        public MyStack()
        {
        }
        public void push(int x)
        {
            arr[i] = x;
            i = i+1;
        }
        public int pop()
        {
            int result = arr[i - 1];
            arr[i - 1] = 0;
            i = i-1;
            return result;
        }

    }
}
