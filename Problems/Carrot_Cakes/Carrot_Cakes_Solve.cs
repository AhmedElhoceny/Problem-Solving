using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Carrot_Cakes
{
    public class Carrot_Cakes_Solve
    {
        public void Solve()
        {
            var firstData = Console.ReadLine().Split(" ").Select(x => decimal.Parse(x)).ToArray();

            Console.WriteLine((Math.Ceiling(firstData[0] / firstData[2]) * firstData[1]) > firstData[1] + firstData[3] ? "YES" : "NO");
        }
    }
}
