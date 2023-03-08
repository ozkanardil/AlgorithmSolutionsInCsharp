using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleOfTheLinkedList.Code
{
    public class SolutionOne
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode tempNode = head;
            
            if (head.next == null)
                return head;
            
            int counter = 1;

            while (head.next != null)
            {
                head = head.next;
                counter++;
            }

            int status = counter % 2;
            int middleIndex = 0;

            middleIndex = (counter/2)+1;

            int resultCounter = 1;
            while (resultCounter < middleIndex)
            {
                tempNode = tempNode.next;
                resultCounter++;
            }

            return tempNode;
        }
    }
}
