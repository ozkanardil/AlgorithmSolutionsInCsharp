// See https://aka.ms/new-console-template for more information
using Subsequence.Code;

Console.WriteLine("Hello, World!");

SolutionOne MyClass = new SolutionOne();
string s = "aaaaaa";
string t = "bbaaaa";
var result = MyClass.IsSubsequence(s, t);
Console.WriteLine(result);