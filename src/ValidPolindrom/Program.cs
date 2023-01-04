// See https://aka.ms/new-console-template for more information
using ValidPolindrom.Code;

Console.WriteLine("Hello, World!");

//SolutionOne myClass = new SolutionOne();
SolutionTwo myClass = new SolutionTwo();
bool result = myClass.IsPalindrome("A mvan, a plan, a canal: Panama");
Console.WriteLine(result);