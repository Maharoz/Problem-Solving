namespace MergeTwoSortedArray
{

	//https://www.geeksforgeeks.org/merge-two-sorted-arrays/
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			int[] f = { 1, 3, 4, 5 };
			int[] s = { 2, 4, 6, 8 };
			mergeSortedArray(f, s);
		}
		static int[] mergeSortedArray(int[] f, int[] s) {
			int[] res = new int[f.Length+s.Length];

			res = f.Concat(s).ToArray();
			Array.Sort(res);
			return res;
		}
	}
}