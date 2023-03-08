using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedList.Code
{
    public class SolutionOne
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = new ListNode();
            ListNode temp = result;
            list1 = list1.next;
            list2 = list2.next;

            while (list1 != null && list2 != null)
            {
                    if (list1.val <= list2.val)
                    {
                        temp.next = list1;
                        temp = temp.next;
                        list1 = list1.next;
                    }
                    else
                    {
                        temp.next = list2;
                        temp = temp.next;
                        list2 = list2.next;
                    }
            }

            while (list1 != null)
            {
                temp.next = list1;
                temp = temp.next;
                list1 = list1.next;
            }

            while (list2 != null)
            {
                temp.next = list2;
                temp = temp.next;
                list2 = list2.next;
            }

            return result.next;

        }
    }
}
