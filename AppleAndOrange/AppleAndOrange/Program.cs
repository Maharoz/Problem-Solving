using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleAndOrange
{
    class Program
    {

        //Problem Url-->https://www.hackerrank.com/challenges/apple-and-orange/submissions/code/123714122
        static void Main(string[] args)
        {

            var home = Console.ReadLine().Split(' ');
            var a_h = Array.ConvertAll(home, int.Parse);

            var tree = Console.ReadLine().Split(' ');
            var a_t = Array.ConvertAll(tree, int.Parse);

            var fruits = Console.ReadLine().Split(' ');
            var a_f = Array.ConvertAll(fruits, int.Parse);

            var apple = Console.ReadLine().Split(' ');
            var apple_falling = Array.ConvertAll(apple, int.Parse);

            var orange = Console.ReadLine().Split(' ');
            var orange_falling = Array.ConvertAll(orange, int.Parse);

            int totalApple = 0;
            int totalOrange = 0;
            foreach (var item in apple_falling)
            {
                var apple_falling_position = item + a_t[0];
                if (apple_falling_position >= a_h[0] && apple_falling_position <= a_h[1])
                {
                    totalApple += 1;
                }
            }

            foreach (var item in orange_falling)
            {
                var orange_falling_position = item + a_t[1];
                if (orange_falling_position >= a_h[0] && orange_falling_position <= a_h[1])
                {
                    totalOrange += 1;
                }
            }

            Console.WriteLine(totalApple);
            Console.WriteLine(totalOrange);


        }
    }
}
