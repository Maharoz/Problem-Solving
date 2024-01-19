namespace PrintOneToNWithoutLoop
{

    //https://www.geeksforgeeks.org/problems/print-1-to-n-without-using-loops-1587115620/
    internal class Program
    {
        static void Main(string[] args)
        {
            printNos(10);
        }

        public static void printNos(int N)
        {
            if(N > 0)
            {
                printNos(N-1);
                Console.Write(N+ " ");
            }
          
        }
    }
}
