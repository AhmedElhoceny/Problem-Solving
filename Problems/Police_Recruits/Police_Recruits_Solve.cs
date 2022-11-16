using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Police_Recruits
{
    public class Police_Recruits_Solve
    {
        public void Solve()
        {
            var Count = int.Parse(Console.ReadLine());
            var Data = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            var Crimes = 0;
            var Cops = 0;
            var Result = 0;

            for (int i = 0; i < Count; i++)
            {
                if (Data[i] > 0)
                {
                    Cops += Data[i];
                }
                else if (Data[i] < 0)
                {
                    Crimes += Math.Abs(Data[i]);
                    if ((i + 1) < Count)
                    {
                        if (Data[i + 1] > 0)
                        {
                            if ((Crimes - Cops) > 0)
                            {
                                Result += (Crimes - Cops);
                            }
                            if (Result < 0)
                                Result = 0;
                            Cops = 0;
                            Crimes = 0;
                        }
                    }
                }
            }
            if (Data[Count - 1] < 0)
            {
                Result += (Crimes - Cops);
                if (Result < 0)
                    Result = 0;
            }

            Console.WriteLine(Result);
        }
    }
}
