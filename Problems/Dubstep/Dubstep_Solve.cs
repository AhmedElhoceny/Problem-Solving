using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Dubstep
{
    public class Dubstep_Solve
    {
        public void Solve()
        {
            var encriptedText = Console.ReadLine();
            var Song = "";
            var chars = encriptedText.Split("WUB").ToList();
            foreach (var item in chars)
            {
                Song += item + " ";
            }
            Console.WriteLine(Song.Trim());
        }
    }
}
