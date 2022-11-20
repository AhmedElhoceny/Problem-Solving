using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Football
{
    public class Football_Solve
    {
        public void Solve()
        {
            var count = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray()[0];
            var FirstTeam = 0;
            var secondTeam = 0;
            var firstName = "";
            var secondName = "";
            for (int i = 0; i < count; i++)
            {

                if (i == 0)
                {
                    FirstTeam++;
                    firstName = Console.ReadLine();
                }

                else
                {
                    var checkingName = Console.ReadLine();
                    if (checkingName == firstName)
                    {
                        FirstTeam++;
                    }
                    else
                    {
                        secondTeam++;
                        secondName = checkingName;
                    }
                }
            }
            if (FirstTeam > secondTeam)
                Console.WriteLine(firstName);
            else
                Console.WriteLine(secondName);
        }
    }
}
