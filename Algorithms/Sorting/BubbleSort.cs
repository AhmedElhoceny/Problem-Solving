using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Algorithms.Sorting
{
    public class BubbleSort
    {
        public int[] SortArray(int[] Array)
        {
            var n = Array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (Array[j] > Array[j + 1])
                    {
                        var tempVar = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = tempVar;
                    }
            return Array;
        }
    }
}
