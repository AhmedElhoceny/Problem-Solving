using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Olesya_and_Rodion
{
    public class Olesya_and_Rodion_Solve
    {
        public void Solve()
        {
            var inputs = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var startPoint = (Math.Pow(10, inputs[0])) / 10;
            var steps = inputs[1] - (startPoint % inputs[1]);
            if ((startPoint + steps) < (startPoint * 10))
                Console.WriteLine(startPoint + steps);
            else
                Console.WriteLine(-1);
        }
    }
}
