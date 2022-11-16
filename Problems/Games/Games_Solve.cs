using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Games
{
    public class Games_Solve
    {
        public void Solve()
        {
            int TeamsNumber = int.Parse(Console.ReadLine());
            string[] TeamsData = new string[TeamsNumber];
            int The_Final_Return = 0;
            for (int i = 0; i < TeamsNumber; i++)
            {
                TeamsData[i] = Console.ReadLine();
            }
            foreach (var HomeTeam in TeamsData)
            {
                foreach (var Guistitem in TeamsData)
                {
                    if (int.Parse(HomeTeam.Split()[1]) == int.Parse(Guistitem.Split()[0]))
                    {
                        The_Final_Return++;
                    }
                }
            }
            Console.WriteLine(The_Final_Return);
        }
    }
}
