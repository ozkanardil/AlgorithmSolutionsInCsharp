using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningSumOfOneDArray.Code
{
    public class SolutionOne
    {
        public int[] RunningSum(int[] nums)
        {
            int mySum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                mySum = mySum + nums[i];
                nums[i] = mySum;
            }
            return nums;
        }
    }
}
