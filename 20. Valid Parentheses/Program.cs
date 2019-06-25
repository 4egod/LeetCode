using System;

namespace _20._Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            object res;

            res = Invoker.Invoke("()"); // true
            res = Invoker.Invoke("()[]{}"); // true
            res = Invoker.Invoke("(]"); // false
            res = Invoker.Invoke("([)]"); // false
            res = Invoker.Invoke("{[]}"); // true
            res = Invoker.Invoke("["); // false
            res = Invoker.Invoke("[([]])"); // false
            res = Invoker.Invoke("([)"); // false
            res = Invoker.Invoke("{}{}()[]"); // true;
            res = Invoker.Invoke("]"); // false

        }
    }
}
