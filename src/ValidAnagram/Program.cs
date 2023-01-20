// See https://aka.ms/new-console-template for more information
using ValidAnagram.code;

Console.WriteLine("Valid anagram!");

SolutionOne myClass = new SolutionOne();
//SolutionTwo myClass = new SolutionTwo();
string s = "anagram";
string t = "nagaram";
Console.WriteLine(myClass.IsAnagram(s, t));
