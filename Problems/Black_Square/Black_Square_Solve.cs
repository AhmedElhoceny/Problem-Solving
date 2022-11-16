using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Black_Square
{
    public class Black_Square_Solve
    {
        public void Solve()
        {
            var Calories = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var Sequence = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();

            var TotalResult = 0;

            foreach (var SequenceItem in Sequence)
            {
                TotalResult += Calories[SequenceItem - 1];
            }
            Console.WriteLine(TotalResult);
        }
    }
}
