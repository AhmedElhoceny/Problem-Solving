using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Presents
{
    public class Presents_Solve
    {
        public void Solve()
        {
            var firstInput = int.Parse(Console.ReadLine()[0].ToString());
            var secondInput = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var Result = new int[secondInput.Length];
            foreach (var item in secondInput)
            {
                Result[secondInput[item - 1] - 1] = item;
            }
            Console.WriteLine(string.Join(" ", Result));
        }
    }
}
