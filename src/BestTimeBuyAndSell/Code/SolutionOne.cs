using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeBuyAndSell.Code
{
    public class SolutionOne
    {
        public int[] FindBestTime(int[] nums)
        {
            int[] result = new int[3];

            int leftPoint = 0;
            int rightPoint = 1;
            int maxProfit = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] < nums[leftPoint])
                {
                    leftPoint = i + 1;
                }
                else if (nums[i + 1] > nums[i])
                {
                    int diffSell = nums[i + 1] - nums[leftPoint];
                    maxProfit = diffSell > maxProfit ? diffSell : maxProfit;
                    rightPoint = i + 1;
                }



            }

            result[0] = leftPoint;
            result[1] = rightPoint;
            result[2] = maxProfit;
            return result;
        }
    }
}
