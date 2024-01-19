namespace SubArrayWithGivenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = { 1, 2, 3, 7, 5 };
            List<int> ab = new List<int>();
            ab.Add(1);
           // ab.Add(2);
           // ab.Add(3);
           // ab.Add(7);
           // ab.Add(5);
            subarraySum(ab, 0, 0);
        }

        public static List<int> subarraySum(List<int> arr, int n, long s)
        {
            int last = 0;
            int start = 0;
            long currsum = 0;
            bool flag = false;
            List<int> res = new List<int>();

            for (int i = 0; i < n; i++)
            {
                currsum += arr[i];

                if (currsum >= s)
                {
                    last = i;
                    while (s < currsum && start < last)
                    {
                        currsum -= arr[start];
                        ++start;
                    }

                    if (currsum == s)
                    {
                        res.Add(start + 1);
                        res.Add(last + 1);

                        flag = true;
                        break;
                    }
                }
            }
            //if no subarray is found, we store -1 in result.
            if (flag == false)
                res.Add(-1);

            //returning the result.
            return res;
        }
    }
}
