//https://practice.geeksforgeeks.org/problems/parenthesis-checker2744/1?page=1&difficulty[]=0&category[]=Stack&sortBy=submissions

CheckString("{([])}");

static bool CheckString(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return true;
    }

    Stack<char> brackets = new Stack<char>();

    foreach (var c in input)
    {
        if (c == '[' || c == '{' || c == '(')
        {
            brackets.Push(c);
        }
        else if (c == ']' || c == '}' || c == ')')
        {
            if (brackets.Count() <= 0)
            {
                return false;
            }
            char open = brackets.Pop();

            if (c == '}' && open != '{' ||
         c == ')' && open != '(' ||
         c == ']' && open != '[')
                return false;
        }
    }

    if (brackets.Count > 0)
        return false;

    return true;
}
