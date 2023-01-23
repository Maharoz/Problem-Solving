
//https://practice.geeksforgeeks.org/problems/leaders-in-an-array-1587115620/1?page=1&difficulty[]=0&sortBy=submissions

int[] array = { 63, 70, 80, 33, 33, 47, 20 };
leaders(array, array.Length);
 static int[] leaders(int[] arr, int N)
{
    List<int> list = new List<int>();
    int max = arr[0];

    for (int i = 0; i < arr.Length - 2; i++)
    {

        if (arr[i + 1] - arr[i] > 0)
        {
            list.Add(arr[i + 1]);
        }
    }
    list.Add(arr[arr.Length - 1]);
    return list.ToArray();
}