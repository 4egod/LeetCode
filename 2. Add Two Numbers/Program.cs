using System;

namespace _2._Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            object res;
            ListNode l1, l2;

            l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            res = Invoker.Invoke(l1, l2);

            l1 = new ListNode(0);
            l2 = new ListNode(0);
            res = Invoker.Invoke(l1, l2);

            l1 = new ListNode(9);
            l2 = new ListNode(1);
            l2.next = new ListNode(9);
            l2.next.next = new ListNode(9);
            l2.next.next.next = new ListNode(9);
            l2.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next.next = new ListNode(9);
            l2.next.next.next.next.next.next.next.next.next = new ListNode(9);
            res = Invoker.Invoke(l1, l2);
        }
    }
}
