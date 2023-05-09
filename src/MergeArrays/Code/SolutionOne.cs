using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MergeArrays.Code
{
    public class SolutionOne
    {
        public int[] MergeArraysIntoOneArray(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            int iterateCounter = arr1.Length > arr2.Length ? arr1.Length : arr2.Length;
            int counter = 0;
            int resultCounter = 0;

            while (counter < iterateCounter)
            {
                if(counter < arr1.Length && counter < arr2.Length)
                {
                    if(arr1[counter] < arr2[counter])
                    {
                        result[resultCounter] = arr1[counter];
                        result[resultCounter + 1] = arr2[counter];
                    } else
                    {
                        result[resultCounter] = arr2[counter];
                        result[resultCounter + 1] = arr1[counter];
                    }
                    resultCounter++;
                } else if(counter >= arr1.Length && counter < arr2.Length)
                {
                    result[resultCounter] = arr2[counter];
                } else
                {
                    result[resultCounter] = arr1[counter];
                }
                resultCounter++;
                counter++;
            }
            return result;  
        }
    }
}
