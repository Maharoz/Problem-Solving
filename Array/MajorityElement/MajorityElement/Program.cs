using System.Drawing;

namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] a = { 15};
            majorityElement(a, 1);


        }
        public static int majorityElement(int[] a, int size)
        {
            // your code here
            int result = -1;

            int majorityFactor = size / 2;

           Dictionary<int,int> map = new Dictionary<int,int>();

            foreach (int i in a)
            {
                if (map.ContainsKey(i))
                {
                    map[i]++;
                }
                else
                {
                    map.Add(i, 1);
                }
            }

            int keyWithMaxValue = map.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            int value = map[keyWithMaxValue];
            if (value > majorityFactor)
            {
                result = keyWithMaxValue;
            }
            return result;
        }
    }
}
