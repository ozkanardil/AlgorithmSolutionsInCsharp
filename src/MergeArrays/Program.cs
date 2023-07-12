// See https://aka.ms/new-console-template for more information
using MergeArrays.Code;
using System.Text;

Console.WriteLine("Merging!");

int[] arr1 = new int[6] {2, 8, 22, 100, 1251, 1500};
int[] arr2 = new int[8] {1, 3, 9, 23, 55, 123, 146, 171};

//SolutionOne myClass = new SolutionOne();
SolutionTwo myClass = new SolutionTwo();
int[] result = myClass.MergeArraysIntoOneArray(arr1, arr2);

StringBuilder stringBuilder = new StringBuilder();

foreach (var item in result)
{
    stringBuilder.Append(item + " - ");
}

Console.WriteLine(stringBuilder.ToString());