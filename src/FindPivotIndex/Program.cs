// See https://aka.ms/new-console-template for more information
using FindPivotIndex.Code;

Console.WriteLine("Find Pivot Index");

SolutionOne myClass = new SolutionOne();
int[] nums = new int[] { 1, 2, 3 };
var result = myClass.PivotIndex(nums);
Console.WriteLine(result);