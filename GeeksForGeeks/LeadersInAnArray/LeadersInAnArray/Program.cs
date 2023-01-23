
//https://practice.geeksforgeeks.org/problems/leaders-in-an-array-1587115620/1?page=1&difficulty[]=0&sortBy=submissions

int[] array = { 63, 70, 80, 33, 33, 47, 20 };
printLeaders(array, array.Length);

void printLeaders(int[] arr,
                  int size)
{
    for (int i = 0; i < size; i++)
    {
        int j;
        for (j = i + 1; j < size; j++)
        {
            if (arr[i] <= arr[j])
                break;
        }

        // the loop didn't break
        if (j == size)
            Console.Write(arr[i] + " ");
    }
}