// See https://aka.ms/new-console-template for more information
using RunningSumOfOneDArray.Code;

Console.WriteLine("Running Sum of 1d Array");

SolutionOne myClass = new SolutionOne();
int[] nums = new int[] { 1, 2, 3, 4 };
var result = myClass.RunningSum(nums);
foreach (var item in result)
{
    Console.WriteLine(item);
}