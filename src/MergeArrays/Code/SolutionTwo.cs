using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArrays.Code
{
    public class SolutionTwo
    {
        public int[] MergeArraysIntoOneArray(int[] arr1, int[] arr2)
        {
            PriorityQueue<int, int> pk = new PriorityQueue<int, int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                pk.Enqueue(arr1[i], arr1[i]);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                pk.Enqueue(arr2[i], arr2[i]);
            }

            int[] result = new int[pk.Count];
            int counter = 0;
            while (pk.Count > 0)
            {
                result[counter] = pk.Dequeue();
                counter++;
            }

            return result;
        }
    }
}
