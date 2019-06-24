/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int x) { val = x; }
* }
*/
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int p, q, sum = 0, extra = 0;
        ListNode a = l1, b = l2, res = null, prev = null;

        while (a != null || b != null)
        {
            p = (a != null) ? a.val : 0;
            q = (b != null) ? b.val : 0;

            sum = extra + p + q;
            extra = sum / 10;

            if (prev != null)
            {
                ListNode l = new ListNode(sum % 10);
                prev.next = l;
                prev = l;
            }

            if (res == null)
            {
                res = new ListNode(sum % 10);
                prev = res;
            }

            if (a != null) a = a.next;
            if (b != null) b = b.next;
        };

        if (extra > 0)
        {
            prev.next = new ListNode(extra);
        }

        return res;
    }
}