// See https://aka.ms/new-console-template for more information
using MergeArrays.Code;
using System.Text;

Console.WriteLine("Merging!");

int[] arr1 = new int[2] {2, 8};
int[] arr2 = new int[3] {1, 3, 9};

SolutionOne myClass = new SolutionOne();
int[] result = myClass.MergeArraysIntoOneArray(arr1, arr2);

StringBuilder stringBuilder = new StringBuilder();

foreach (var item in result)
{
    stringBuilder.Append(item + " - ");
}

Console.WriteLine(stringBuilder.ToString());