using System;

namespace _9._Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            object res;

            res = Invoker.Invoke(121);
            res = Invoker.Invoke(-121);
            res = Invoker.Invoke(10);
        }
    }
}
