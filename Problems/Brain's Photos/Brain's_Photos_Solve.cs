using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Brain_s_Photos
{
    public class Brain_s_Photos_Solve
    {
        public void Solve()
        {
            var columns = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray()[0];
            var colors = new List<string>();
            for (int i = 0; i < columns; i++)
            {
                var row = Console.ReadLine().Split(" ").ToList();
                colors.AddRange(row);
            }
            colors.Distinct();
            if (colors.All(x => x == "W" || x == "G" || x == "B"))
                Console.WriteLine("#Black&White");
            else
                Console.WriteLine("#Color");
        }
    }
}
