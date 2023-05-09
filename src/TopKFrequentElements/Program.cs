// See https://aka.ms/new-console-template for more information
using System.Text;
using TopKFrequentElements.Codes;

Console.WriteLine("Top K Frequent Elements");

int[] nums = { 1, 1, 1, 2, 2, 3, 3, 3, 4 };
int k = 2;

SolutionOne myClass = new SolutionOne();
var result = myClass.TopKFrequent(nums, k);
StringBuilder StringBuilder = new StringBuilder();

for (int i = 0; i < result.Length; i++)
{
    StringBuilder.Append(result[i] + " - ");
}

Console.WriteLine(StringBuilder.ToString());