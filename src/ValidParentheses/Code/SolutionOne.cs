using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses.Code
{
    public class SolutionOne
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            char[] chars = s.ToCharArray();

            if (chars.Length < 2)
                return false;

            foreach (var item in chars)
            {
                if (item == '(')
                    stack.Push(item);

                if (item == '[')
                    stack.Push(item);

                if (item == '{')
                    stack.Push(item);

                char lastChar;

                if (item == ')')
                {
                    if (stack.Count == 0)
                        return false;

                    lastChar = stack.Pop();
                    if (lastChar != '(')
                        return false;
                }

                if (item == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    lastChar = stack.Pop();
                    if (lastChar != '[')
                        return false;
                }

                if (item == '}')
                {
                    if (stack.Count == 0)
                        return false;

                    lastChar = stack.Pop();
                    if (lastChar != '{')
                        return false;
                }
            }

            if (stack.Count == 0)
                return true;

            return false;
        }
    }
}
