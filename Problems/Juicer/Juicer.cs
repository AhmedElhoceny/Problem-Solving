using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Juicer
{
    public class Juicer
    {
        public void Solve()
        {
            var firstData = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var secondData = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            var totalSum = 0;

            foreach (var secondDataItem in secondData)
            {
                if (secondDataItem < firstData[2])
                {
                    totalSum += secondDataItem;
                }
            }
            Console.WriteLine(totalSum / firstData[2]);
        }
    }
}
