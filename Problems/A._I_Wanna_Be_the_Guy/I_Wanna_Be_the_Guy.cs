using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.A._I_Wanna_Be_the_Guy
{
    public class I_Wanna_Be_the_Guy
    {
        public void Solve()
        {
            var levelCount = Console.ReadLine().Split("").Select(x => int.Parse(x)).ToList();
            var XLevels = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).Where(x => x != 0).ToList();
            var YLevels = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).Where(x => x != 0).ToList();
            XLevels.AddRange(YLevels);
            var totalLevels = XLevels.Distinct().Count();
            if (totalLevels >= levelCount[0])
                Console.WriteLine("I become the guy.");
            else
                Console.WriteLine("Oh, my keyboard!");
        }
    }
}
