using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Code
{
    public class SolutionOne
    {
        public int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (nums[mid] == target)
                    return mid;

                if (target < nums[mid])
                    high = mid - 1;

                if (target > nums[mid])
                    low = mid + 1;
            }

            return -1;
        }
    }
}
