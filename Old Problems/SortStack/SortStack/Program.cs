// https://practice.geeksforgeeks.org/problems/sort-a-stack/1?page=1&difficulty[]=0&category[]=Stack&sortBy=submissions

Stack<int> input = new Stack<int>();
input.Push(34);
input.Push(3);
input.Push(31);
input.Push(98);
input.Push(92);
input.Push(23);

// This is the temporary stack
Stack<int> tmpStack = sort(input);
Console.WriteLine("Sorted numbers are:");

while (tmpStack.Count > 0)
{
    Console.Write(tmpStack.Pop() + " ");
}

Stack<int> sort(Stack<int> input)
{
	//add code here.
    Stack<int> tmpStack = new Stack<int>();  
    while(input.Count > 0)
    {
        int tmp =input.Pop();

        while(tmpStack.Count >0 && tmpStack.Peek() > tmp)
        {
            input.Push(tmpStack.Pop());
        }
        tmpStack.Push(tmp);
    }
    return tmpStack;

}
