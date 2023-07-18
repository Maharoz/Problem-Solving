using System;

namespace Doctor_s_Secret
{
    class Program
    {
        static void Main(string[] args)
        {
            string r1;
            string[] a = Console.ReadLine().Split();
            int length = Convert.ToInt32(a[0]);
            int page = Convert.ToInt32(a[1]);

            if (length <= 23)
            {
                 r1 = "Take";
            }
            else
            {
                 r1 = "Don't take";
            }

            Console.WriteLine(r1 + " Medicine");
        }
    }
}
