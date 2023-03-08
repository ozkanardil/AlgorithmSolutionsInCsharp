// See https://aka.ms/new-console-template for more information
using MergeTwoSortedList.Code;

Console.WriteLine("Merge Two Sorted List!");

SolutionOne MyClass = new SolutionOne();

ListNode list1 = new ListNode();
ListNode list1Temp = list1;

ListNode list1Item1 = new ListNode();
list1Item1.val = 1;
list1Temp.next = list1Item1;
list1Temp = list1Temp.next;

ListNode list1Item2 = new ListNode();
list1Item2.val = 2;
list1Temp.next = list1Item2;
list1Temp = list1Temp.next;

ListNode list1Item3 = new ListNode();
list1Item3.val = 4;
list1Temp.next = list1Item3;
list1Temp = list1Temp.next;

ListNode list2 = new ListNode();
ListNode list2Temp = list2;

ListNode list2Item1 = new ListNode();
list2Item1.val = 1;
list2Temp.next = list2Item1;
list2Temp = list2Temp.next;

ListNode list2Item2 = new ListNode();
list2Item2.val = 3;
list2Temp.next = list2Item2;
list2Temp = list2Temp.next;

ListNode list2Item3 = new ListNode();
list2Item3.val = 4;
list2Temp.next = list2Item3;
list2Temp = list2Temp.next;

var result = MyClass.MergeTwoLists(list1, list2);
string sonuc = "";

while(result != null)
{
    sonuc += result.val + " - ";
    result = result.next;
}

Console.WriteLine(sonuc);
