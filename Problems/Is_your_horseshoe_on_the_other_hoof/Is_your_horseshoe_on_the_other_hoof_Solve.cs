using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Is_your_horseshoe_on_the_other_hoof
{
    public class Is_your_horseshoe_on_the_other_hoof_Solve
    {
        public void Solve()
        {
            var Data = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToList().Distinct();
            Console.WriteLine(4 - Data.Count());
        }
    }
}
