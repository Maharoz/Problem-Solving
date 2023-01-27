namespace reorder_the_array_according_to_given_index
{
	//https://www.geeksforgeeks.org/reorder-a-array-according-to-given-indexes/
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 10, 11, 12 };
			int[] index = { 1, 0, 2 };
			reOrderedArray(arr, index);
		}
		static int[] reOrderedArray(int[] array, int[] index)
		{
			int[] result = new int[array.Length];	

			for(int i=0; i<array.Length;i++)
			{
				int x = index[i];
				result[x] =array[i];
			}
			return result;
		}
	}
}