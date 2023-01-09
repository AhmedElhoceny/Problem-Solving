using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Sereja_and_Dima
{
    public class Sollusion
    {
        public void Solve()
        {
            var cardsCount = Console.ReadLine()!.Select(x => long.Parse(x.ToString())).ToArray()[0];
            var cards = Console.ReadLine()!.Split(" ").Select(x => long.Parse(x.ToString())).ToArray();

            var F_or_S = false;

            var top = 0;
            var rear = cards.Length - 1;

            long firstPlayer = 0;
            long secondPlayer = 0;

            while (rear >= top)
            {
                long workingValue = 0;

                if (cards[top] >= cards[rear])
                {
                    workingValue = cards[top];
                    top++;
                }
                else
                {
                    workingValue = cards[rear];
                    rear--;
                }

                if (F_or_S)
                {
                    firstPlayer += workingValue;
                }
                else
                {
                    secondPlayer += workingValue;
                }

                F_or_S = !F_or_S;
            }

            Console.WriteLine($"{secondPlayer} {firstPlayer}");
        }
    }
}
