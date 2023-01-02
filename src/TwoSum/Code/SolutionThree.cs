using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum.Code
{
    public class SolutionThree
    {
        public int[] TwoSum(int[] nums, int target)
        {
            IDictionary<int, int> hashtable = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var other = target - nums[i];

                if (hashtable.ContainsKey(other))
                {
                    return new[] { i, hashtable[other] };
                }

                hashtable[nums[i]] = i;
            }

            return null;

        }
    }
}
