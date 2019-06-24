using System;

namespace _26._Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            object res;
            int[] a;

            res = Invoker.Invoke(a = new int[] { 1, 1, 2 });
            res = Invoker.Invoke(a = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            res = Invoker.Invoke(a = new int[] { 1, 1, 1 });
            res = Invoker.Invoke(a = new int[] { 1, 2, 2, 2 });
            res = Invoker.Invoke(a = new int[] { 0, 0, 0, 0, 0, 1, 2, 2, 3, 3, 4, 4 });
        }
    }
}
