namespace count_the_number_of_possible_triangle
{

	//https://www.geeksforgeeks.org/find-number-of-triangles-possible/
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 10, 21, 22, 100, 101, 200, 300 };
			int size = arr.Length;

			// Function call
			Console.WriteLine(
				"Total number of triangles possible is "
				+ findPossibleTriangle(arr, size));
		}
		static int findPossibleTriangle(int[] arr, int n)
		{
			int count = 0;

			for(int i =0;i<n; i++)
			{
				for (int j = i+1; j < n; j++)
				{
					for (int k = j + 1; k < n; k++)
					{
						if (arr[i] + arr[j] > arr[k]
					  && arr[i] + arr[k] > arr[j]
					  && arr[k] + arr[j] > arr[i])
							count++;
					}
				}
			}
			return count;
		}
	}
}