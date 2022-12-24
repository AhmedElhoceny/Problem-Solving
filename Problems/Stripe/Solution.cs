using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Stripe
{
    public class Solution
    {
        public void Solve()
        {
            var dataLenth = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToArray()[0];
            var data = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var PreSumArray = new int[] { };
            var generalCounter = 0;
            for (long i = 0; i < dataLenth; i++)
            {
                if (i != 0)
                {
                    PreSumArray = PreSumArray.Append(PreSumArray[i - 1] + data[i]).ToArray();
                }
                else
                {
                    PreSumArray = PreSumArray.Append(data[i]).ToArray();
                }
            }
            for (long i = 0; i < (dataLenth - 1); i++)
            {
                if (PreSumArray[dataLenth - 1] - PreSumArray[i] == PreSumArray[i])
                {
                    generalCounter++;
                }
            }
            Console.WriteLine(generalCounter);
        } 
    }
}
