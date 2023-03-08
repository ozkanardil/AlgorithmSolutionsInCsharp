// See https://aka.ms/new-console-template for more information
using MiddleOfTheLinkedList.Code;

Console.WriteLine("Middle of the Linked List!");

SolutionOne MyClass = new SolutionOne();

ListNode list1 = new ListNode();
ListNode list1Temp = list1;

for (int i = 1; i < 7; i++)
{
    ListNode item = new ListNode();
    item.val = i;
    list1Temp.next = item;
    list1Temp = list1Temp.next;
}

var result = MyClass.MiddleNode(list1.next);

Console.WriteLine(result.val);
