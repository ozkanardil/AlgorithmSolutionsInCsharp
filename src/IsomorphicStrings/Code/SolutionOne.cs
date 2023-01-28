using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsomorphicStrings.Code
{
    public class SolutionOne
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            
            int counter = 1;
            var arrS = new int[127];
            var arrT = new int[127];

            for (int i = 0; i < s.Length; i++)
            {
                if (arrS[s[i]] != arrT[t[i]])
                    return false;
                else if (arrS[s[i]] == 0)
                {
                    arrS[s[i]] = counter;
                    arrT[t[i]] = counter;
                    counter++;
                }
            }
            return true;
        }
    }
}
