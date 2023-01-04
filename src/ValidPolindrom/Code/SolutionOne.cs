using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPolindrom.Code
{
    public class SolutionOne
    {

        public bool IsPalindrome(string s)
        {
            char[] myOriginalChars = s.ToCharArray();
            string myText = "";

            bool result = false;

            foreach (var item in myOriginalChars)
            {
                bool isValid = item.ToString().All(c => char.IsLetterOrDigit(c));
                if (isValid)
                {
                    myText = myText + item.ToString().ToLower(); ;
                }
            }

            char[] myReversedChars = myText.ToCharArray();
            Array.Reverse(myReversedChars);
            string myReversedString = new string(myReversedChars);

            if (myText == myReversedString)
                result = true;

            return result;
        }

    }
}
