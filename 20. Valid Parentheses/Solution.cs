using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> x = new Stack<char>();

        foreach (var item in s)
        {
            switch (item)
            {
                case '(':
                    x.Push(')');
                    break;
                case '[':
                    x.Push(']');
                    break;
                case '{':
                    x.Push('}');
                    break;
                default:
                    if (x.Count == 0 || x.Pop() != item)
                    {
                        return false;
                    }

                    break;
            }
        }

        return x.Count == 0;
    }
}