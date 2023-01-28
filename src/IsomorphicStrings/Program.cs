// See https://aka.ms/new-console-template for more information
using IsomorphicStrings.Code;

Console.WriteLine("Isomorphic Strings!");


SolutionOne myClass = new SolutionOne();
string str1 = "paper";
string str2 = "title";
var result = myClass.IsIsomorphic(str1, str2);
Console.WriteLine(result);