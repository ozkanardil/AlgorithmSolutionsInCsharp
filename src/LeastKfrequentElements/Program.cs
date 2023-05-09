// See https://aka.ms/new-console-template for more information
using LeastKfrequentElements.Codes;
using System.Text;

Console.WriteLine("Hello, World!");

int[] nums = { 1, 1, 1, 2, 2, 3, 3, 3, 4 };
int k = 2;

SolutionOne myClass = new SolutionOne();
var result = myClass.LeastKFrequent(nums, k);
StringBuilder stringBuilder = new StringBuilder();

for (int i = 0; i < result.Length; i++)
{
    stringBuilder.Append(result[i].ToString() + " - ");
}

Console.WriteLine(stringBuilder.ToString());