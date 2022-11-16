using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Twins
{
    public class Twins_Solve
    {
        public void Solve()
        {
            var counterInput = int.Parse(Console.ReadLine()[0].ToString());
            var coinsSerial = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            coinsSerial = coinsSerial.OrderByDescending(x => x).ToList();

            long totalSum = 0;
            int takenValue = 0;
            int takenCounsCounter = 0;

            foreach (var item in coinsSerial)
            {
                totalSum += item;
            }

            foreach (var item in coinsSerial)
            {
                takenValue += item;
                takenCounsCounter++;
                if (takenValue > (totalSum - takenValue))
                    break;
            }

            Console.WriteLine(takenCounsCounter);
        }
    }
}
