// See https://aka.ms/new-console-template for more information
using MergeLists.Codes;
using System.Text;

Console.WriteLine("Hello, World!");

List<int> list1 = new List<int> { 2, 8 };
List<int> list2 = new List<int> { 1, 3, 9 };

SolutionOne myClass = new SolutionOne();
List<int> result = myClass.MergeListsIntoOneList(list1, list2);

StringBuilder stringBuilder = new StringBuilder();

foreach (var item in result)
{
    stringBuilder.Append(item + " - ");
}

Console.WriteLine(stringBuilder.ToString());