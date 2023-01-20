using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPivotIndex.Code
{
    public class SolutionOne
    {
        public int PivotIndex(int[] nums)
        {
            int totalSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                totalSum = totalSum + nums[i];
            }

            int leftSum = 0;

            for (int k = 0; k < nums.Length; k++)
            {
                int rightSum = totalSum - nums[k] - leftSum;

                if (rightSum == leftSum)
                {
                    return k;
                }

                leftSum = leftSum + nums[k];
            }
            return -1;
        }
    }
}
