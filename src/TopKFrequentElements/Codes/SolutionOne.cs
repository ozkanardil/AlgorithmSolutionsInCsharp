using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopKFrequentElements.Codes
{
    public class SolutionOne
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            List<int> list = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                bool checkDict = dict.ContainsKey(nums[i]);
                if (!checkDict)
                {
                    dict.Add(nums[i], 1);
                } else
                {
                    dict[nums[i]] = dict[nums[i]] + 1;
                }
            }

            var pk = new PriorityQueue<int, int>();
            foreach (KeyValuePair<int, int> item in dict)
            {
                pk.Enqueue(item.Key, item.Value);
                if(pk.Count > k)
                    pk.Dequeue();
            }

            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = pk.Dequeue();
            }

            return result;
        }
    }
   
}
