using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeArrays.Code
{
    public class SolutionThree
    {
        public int[] MergeArraysIntoOneArray(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);

            int[] result = new int[arr1.Length + arr2.Length];
            int counterResult = 0;
            int counterArr1 = 0;
            int counterArr2 = 0;

            while (counterResult < arr1.Length && counterResult < arr2.Length)
            {
                if(arr1[counterArr1] <= arr2[counterArr2])
                {
                    result[counterResult] = arr1[counterArr1];
                    counterArr1++;

                } else
                {
                    result[counterResult] = arr2[counterArr2];
                    counterArr2++;
                }
                counterResult++;
            }

            while (counterArr1 < arr1.Length)
            {
                result[counterResult] = arr1[counterArr1];
                counterArr1++;
                counterResult++;
            }

            while (counterArr2 < arr2.Length)
            {
                result[counterResult] = arr2[counterArr2];
                counterArr2++;
                counterResult++;
            }

            return result;
        }
    }
}
