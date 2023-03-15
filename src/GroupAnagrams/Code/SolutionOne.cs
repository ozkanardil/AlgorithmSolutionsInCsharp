using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAnagrams.Code
{
    public class SolutionOne
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            string[] strsSorted = new string[strs.Length];

            for (int i = 0; i < strs.Length; i++)
            {
                char[] charArr = strs[i].ToCharArray();
                Array.Sort(charArr);
                strsSorted[i] = new string(charArr);
            }

            IDictionary<string, IList<string>> dicAnagrams = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strsSorted.Length; i++)
            {

                if (dicAnagrams.ContainsKey(strsSorted[i]))
                {
                    dicAnagrams.TryGetValue(strsSorted[i], out var list);
                    list.Add(strs[i]);
                }
                else
                {
                    IList<string> myList = new List<string>();
                    myList.Add(strs[i]);
                    dicAnagrams.Add(strsSorted[i], myList);
                }

            }

            IList<IList<string>> result = new List<IList<string>>();

            foreach (KeyValuePair<string, IList<string>> kvp in dicAnagrams)
            {
                result.Add(kvp.Value);
            }

            return result;

        }
    }
}
