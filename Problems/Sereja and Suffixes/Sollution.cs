using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Sereja_and_Suffixes
{
    public class Sollution
    {
        public void Solve()
        {
            var first = Console.ReadLine()!.Split(" ").Select(x => long.Parse(x)).ToArray();
            var inputData = Console.ReadLine()!.Split(" ").Select(x => long.Parse(x)).ToArray();
            var resultArray = new List<long>();
            for (long i = 0; i < first[1]; i++)
            {
                var startIndex = Console.ReadLine()!.Split(" ").Select(x => long.Parse(x)).ToArray()[0];
                resultArray.Add(inputData.Skip((int)(startIndex - 1)).ToArray().Distinct().Count());
            }
            foreach (var item in resultArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
