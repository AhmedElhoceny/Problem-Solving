using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Die_Roll
{
    public class Die_Roll
    {
        public void Solve()
        {
            var FirstInputData = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToList();
            var Max = Math.Max(FirstInputData[0], FirstInputData[1]);

            var numerator = (6 - (Max - 1));
            var denominator = 6;

            while (numerator % 2 == 0 && denominator % 2 == 0)
            {
                numerator /= 2;
                denominator /= 2;
            }
            while (numerator % 3 == 0 && denominator % 3 == 0)
            {
                numerator /= 3;
                denominator /= 3;
            }

            Console.WriteLine(numerator.ToString() + "/" + denominator.ToString());
        }
    }
}
