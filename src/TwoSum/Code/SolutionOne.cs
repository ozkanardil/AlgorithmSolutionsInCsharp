using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum.Code
{
    public class SolutionOne
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[k] == target)
                    {
                        result[0] = i;
                        result[1] = k;
                    }
                }
            }

            return result;
        }
    }
}
