using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedLinkedList.Code
{
    public class SolutionOne
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            if (head.next == null)
                return head;

            ListNode pointer = null;
            ListNode follower = null;

            while (head != null)
            {
                pointer = head.next;
                head.next = follower;
                follower = head;
                head = pointer;
            }

            return follower;
        }
    }
}
