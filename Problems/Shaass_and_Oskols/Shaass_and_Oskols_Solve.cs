using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Shaass_and_Oskols
{
    public class Shaass_and_Oskols_Solve
    {
        public void Solve()
        {
            var boxesCount = int.Parse(Console.ReadLine().Split(" ")[0]);
            var boxesValues = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            var processesCount = int.Parse(Console.ReadLine().Split(" ")[0]);
            var processes = new List<string>();
            for (int i = 0; i < processesCount; i++)
            {
                processes.Add(Console.ReadLine());
            }
            foreach (var processesItem in processes)
            {
                var proVals = processesItem.Split(" ").Select(x => int.Parse(x)).ToArray();
                var leftVal = proVals[1] - 1 > 0 ? proVals[1] - 1 : 0;
                var rightVal = boxesValues[proVals[0] - 1] - (leftVal + 1) > 0 ? boxesValues[proVals[0] - 1] - (leftVal + 1) : 0;
                boxesValues[proVals[0] - 1] = 0;
                if (proVals[0] - 2 >= 0)
                    boxesValues[proVals[0] - 2] += leftVal;
                if (proVals[0] < boxesCount)
                    boxesValues[proVals[0]] += rightVal;
            }
            foreach (var item in boxesValues)
            {
                Console.WriteLine(item);
            }
        }
    }
}
