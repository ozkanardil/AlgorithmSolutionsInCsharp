using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum.Code
{
    public class SolutionTwo
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                int existInArray = Array.IndexOf(nums, diff);

                if (existInArray != i)
                {
                    if (existInArray != -1)
                    {
                        result[0] = i;
                        result[1] = existInArray;
                        break;
                    }
                }

            }
            return result;

        }
    }
}
