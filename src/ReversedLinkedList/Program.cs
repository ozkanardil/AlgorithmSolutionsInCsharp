// See https://aka.ms/new-console-template for more information
using ReversedLinkedList.Code;

Console.WriteLine("Reversed Linked List!");

SolutionOne MyClass = new SolutionOne();

ListNode list1 = new ListNode();
ListNode list1Temp = list1;

for (int i = 1; i < 6; i++)
{
    ListNode item = new ListNode();
    item.val = i;
    list1Temp.next = item;
    list1Temp = list1Temp.next;
}

var result = MyClass.ReverseList(list1.next);
string sonuc = "";

while (result != null)
{
    sonuc += result.val + " - ";
    result = result.next;
}

Console.WriteLine(sonuc);