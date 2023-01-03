// See https://aka.ms/new-console-template for more information
using ValidParentheses.Code;

Console.WriteLine("Hello, World!");

SolutionOne myClass = new SolutionOne();
//SolutionTwo myClass = new SolutionTwo();
string myText = "(])";
Console.WriteLine(myClass.IsValid(myText));