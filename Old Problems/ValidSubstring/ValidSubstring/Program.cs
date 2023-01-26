//https://practice.geeksforgeeks.org/problems/valid-substring0624/1

static int findMax(string s)
{
    int n = s.Length;

    Stack<int> stack = new Stack<int>();
    stack.Push(-1);
    int result = 0;

    for (int i = 0; i < n; i++)
    {
        if (s[i] == '(')
        {
            stack.Push(i);
        }
        else
        {
            if (stack.Count > 0)
            {
                stack.Pop();
            }

            if (stack.Count > 0)
            {
                result
                    = Math.Max(result,
                               i - stack.Peek());
            }

            else
            {
                stack.Push(i);
            }
        }
    }
    return result;

}

//string str = "((()()";

//// Function call
//Console.WriteLine(findMax(str));

string str = ")(()))))";

// Function call
Console.WriteLine(findMax(str));