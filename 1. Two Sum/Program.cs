using System;

namespace _1._Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            object res;

            res = Invoker.Invoke(new int[] { 2, 7, 11, 15 }, 9); // [0, 1]
            res = Invoker.Invoke(new int[] { 2, 5, 5, 11 }, 10);
            res = Invoker.Invoke(new int[] { 3, 3 }, 6);
            res = Invoker.Invoke(new int[] { 0, 4, 3, 0 }, 0); // [0, 3]
        }
    }
}
