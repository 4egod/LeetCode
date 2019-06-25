namespace _35.Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            object res;

            res = Invoker.Invoke(new int[] { 1, 3, 5, 6 }, 5);
            res = Invoker.Invoke(new int[] { 1, 3, 5, 6 }, 2);
            res = Invoker.Invoke(new int[] { 1, 3, 5, 6 }, 7);
            res = Invoker.Invoke(new int[] { 1, 3, 5, 6 }, 0);
            res = Invoker.Invoke(new int[] { 1 }, 2);
        }
    }
}
