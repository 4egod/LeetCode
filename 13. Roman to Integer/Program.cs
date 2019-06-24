using System;

namespace _13._Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            object res;

            res = Invoker.Invoke("III"); // 3
            res = Invoker.Invoke("IV"); // 4
            res = Invoker.Invoke("IX"); // 9
            res = Invoker.Invoke("LVIII"); // 58
            res = Invoker.Invoke("MCMXCIV"); // 1994
            res = Invoker.Invoke("DCXXI"); // 621
        }
    }
}
