// See https://aka.ms/new-console-template for more information
using ContainsDublicate.Code;

Console.WriteLine("Hello, World!");

SolutionOne myClass = new SolutionOne();
int[] nums = new int[] { 1, 2, 3, 1 };
var result = myClass.ContainsDuplicate(nums);
Console.WriteLine(result);