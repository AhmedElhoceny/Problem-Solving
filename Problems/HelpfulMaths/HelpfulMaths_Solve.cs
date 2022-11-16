using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.HelpfulMaths
{
    public class HelpfulMaths_Solve
    {
        public void Solve()
        {
            var data = Console.ReadLine().Split("+").Select(x => int.Parse(x)).ToArray();
            Array.Sort(data);
            Console.WriteLine(String.Join("+", data));
        }
    }
}
