using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPolindrom.Code
{
    public class SolutionTwo
    {
        public bool IsPalindrome(string s)
        {
            bool result = true;

            string withOutSpecialCharacters = new string(s.ToLower().Where(c => char.IsLetterOrDigit(c)).ToArray());
           
            char[] myChars = withOutSpecialCharacters.ToCharArray();

            int i = 0;
            int k = myChars.Length - 1;

            while (i <= k)
            {
                if (myChars[i] != myChars[k])
                {
                    result = false;
                }

                i++;
                k--;
            }

            return result;
        }
    }
}
