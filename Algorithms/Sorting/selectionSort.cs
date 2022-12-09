using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Algorithms.Sorting
{
    public class selectionSort
    {
        public int[] SortArray(int[] Array)
        {
            var arrayLength = Array.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (Array[j] < Array[smallestVal])
                    {
                        smallestVal = j;
                    }
                }
                var tempVar = Array[smallestVal];
                Array[smallestVal] = Array[i];
                Array[i] = tempVar;
            }
            return Array;
        }
    }
}
