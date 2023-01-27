namespace counting_pair_of_given_sum
{
	internal class Program
	{

		//https://practice.geeksforgeeks.org/problems/count-pairs-with-given-sum5022/1?page=1&category[]=Arrays&sortBy=submissions
		static void Main(string[] args)
		{
			int[] a = { 1, 1, 1, 1 };
			pairCount(a, 2);
		}

		static int pairCount(int[] input,int k)
		{
			int count = 0;
			for(int i = 0; i < input.Length-1; i++)
			{
				for(int j =i+1;j< input.Length; j++)
				{
					if (input[i] + input[j] == k)
					{
						count++;
					}
				}
			}
			return count;
		}
	}
}