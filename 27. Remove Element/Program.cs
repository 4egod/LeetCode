namespace _27.Remove_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            object res;

            res = Invoker.Invoke(a = new int[] { 3, 2, 2, 3 }, 3);
            res = Invoker.Invoke(a = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            res = Invoker.Invoke(a = new int[] { 1 }, 1);
            res = Invoker.Invoke(a = new int[] { 4, 5 }, 5);
        }
    }
}
