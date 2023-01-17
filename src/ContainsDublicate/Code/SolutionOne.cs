using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsDublicate.Code
{
    public class SolutionOne
    {
        public bool ContainsDuplicate(int[] nums)
        {
            bool result = false;
            HashSet<int> mySet = new HashSet<int>();
            foreach (int item in nums)
            {
                if (mySet.Contains(item))
                {
                    return true;
                }
                else
                {
                    mySet.Add(item);
                }
            }
            return result;
        }
    }
}
