using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Even_Odds
{
    public class Even_Odds_Solve
    {
        public void solve()
        {
            var firstInput = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
            var checkingLength = Math.Ceiling(firstInput[0] / 2);
            long val = 0;
            if (firstInput[1] <= checkingLength)
                val = (long)(firstInput[1] * 2) - 1;
            else
                val = (long)((firstInput[1] - checkingLength) * 2);
            Console.WriteLine(val);
        }
    }
}
