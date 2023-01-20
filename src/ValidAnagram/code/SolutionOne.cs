using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidAnagram.code
{
    public class SolutionOne
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            char[] sChar = s.ToCharArray();
            char[] tChar = t.ToCharArray();

            Array.Sort(sChar);
            Array.Sort(tChar);

            string sString = new string(sChar);
            string tString = new string(tChar);

            bool result = sString == tString ? true : false;
            return result;
        }
    }
}
