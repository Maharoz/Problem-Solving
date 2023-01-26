//https://practice.geeksforgeeks.org/problems/equilibrium-point-1587115620/1?page=1&difficulty[]=0&sortBy=submissions

int[] arr = { 1, 3, 5, 2, 2 };
int res =equilibriumPoint(arr, 5);
Console.WriteLine(res);
 

static int equilibriumPoint(int[] arr, int N)
{
    int sum = arr.Sum(x => x);
    int runningSum = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if(runningSum == sum- (runningSum + arr[i])){
            return arr[i];
        }
        else
        {
            runningSum += arr[i];
        }

    }
    return 0;
}
