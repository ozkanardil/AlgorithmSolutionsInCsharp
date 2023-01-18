// See https://aka.ms/new-console-template for more information
using BinarySearch.Code;

Console.WriteLine("Binary search!");

SolutionOne myClass = new SolutionOne();
int[] nums = new int[] { -1, 0, 3, 5, 9, 12 };
int target = 2;
var result = myClass.Search(nums, target);
Console.WriteLine(result);