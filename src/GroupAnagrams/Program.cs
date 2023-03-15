// See https://aka.ms/new-console-template for more information
using GroupAnagrams.Code;

Console.WriteLine("Group Anagram!");

SolutionOne myClass = new SolutionOne();
string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
var result = myClass.GroupAnagrams(strs);
Console.WriteLine(result);