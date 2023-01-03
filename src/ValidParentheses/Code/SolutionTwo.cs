using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses.Code
{
    public class SolutionTwo
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();
            keyValuePairs.Add(')', '(');
            keyValuePairs.Add(']', '[');
            keyValuePairs.Add('}', '{');

            char[] chars = s.ToCharArray();

            if (chars.Length < 2)
                return false;

            foreach (var item in chars)
            {
                if (item == '(' || item == '[' || item == '{')
                    stack.Push(item);

                if (item == ')' || item == ']' || item == '}')
                {
                    if (stack.Count == 0)
                        return false;

                    if (stack.First() != keyValuePairs.GetValueOrDefault(item))
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

            }

            if (stack.Count == 0)
                return true;

            return false;
        }
    }
}
