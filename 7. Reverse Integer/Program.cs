using System;

namespace _7._Reverse_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            object res;

            res = Invoker.Invoke(123); // 321
            res = Invoker.Invoke(-123); // 321
            res = Invoker.Invoke(120); // 21
            res = Invoker.Invoke(1534236469); // 0
        }
    }
}
