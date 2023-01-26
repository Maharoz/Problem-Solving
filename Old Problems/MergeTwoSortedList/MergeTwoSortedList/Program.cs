int[] list1 = { 1, 3,5,7,9};
int[] list2 = { 2,4,6,8,10,12};
int[] result = new int[list1.Length + list2.Length];
int i = 0;
int j = 0;
int k = 0;
int count1 = list1.Length;
int count2 = list2.Length;

while(i< count1 && j< count2)
{
    if (list1[i] <= list2[j])
    {
        result[k] = list1[i];
        k++;
        i++;
    }
    else
    {
        result[k] = list2[j];
        k++;
        j++;
    }
}

if(i < count1)
{
    for(int jj=i; jj< count1; jj++)
    {
        result[k]=list1[jj];
        k++; 
    }
}

if(j < count2)
{
    for (int kk = j; kk < count2; kk++)
    {
        result[k] = list2[kk];
        k++;
    }
}

Console.WriteLine("Result is {{ {0} }}", string.Join(",", result.Select(e => e.ToString())));