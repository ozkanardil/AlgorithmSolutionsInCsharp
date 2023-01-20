using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidAnagram.code
{
    public class SolutionTwo
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] sChar = s.ToCharArray();
            char[] tChar = t.ToCharArray();

            Array.Sort(sChar);
            Array.Sort(tChar);

            for (int i = 0; i < sChar.Length; i++)
            {
                if (sChar[i] != tChar[i])
                    return false;
            }
            return true;
        }
    }
}
