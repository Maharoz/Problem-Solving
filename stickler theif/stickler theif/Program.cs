//https://practice.geeksforgeeks.org/problems/stickler-theif-1587115621/1?page=1&difficulty[]=0&category[]=Dynamic%20Programming&sortBy=submissions

int[] a = { 5, 5, 10, 20, 100, 5 };
int x = 6;

FindMaxSum(a, x);

int FindMaxSum(int[] arr, int n)
{
    if (n == 0)
    {
        return 0;
    }
    if (n == 1)
    {
        return arr[0];
    }
    if (n == 2)
    {
        return Math.Max(arr[0], arr[1]);
    }

    int[] b = new int[n];
    b[0] = arr[0];
    b[1] = Math.Max(arr[0], arr[1]);

    for (int i = 2; i < n; i++)
    {
        b[i] = Math.Max(b[i - 2] + arr[i], b[i - 1]);
    }
    return b[n - 1];
}

