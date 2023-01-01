using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.The_Festive_Evening
{
    public class Solving
    {
        public void Solve()
        {
            // Reading Data From User
            var firstInput = Console.ReadLine()!.Split(" ").Select(num => int.Parse(num)).ToArray();
            var secondInput = Console.ReadLine()!.ToCharArray();

            // List To Contains The Guards Orders
            List<char> guardsOrders = new List<char>();

            // Flag to Express The Guards State
            var enougthGuards = true;

            // Get The Giants With Guards 
            for (int i = 0; i < firstInput[0]; i++)
            {
                if (guardsOrders.Contains(secondInput[i]))
                {
                    firstInput[1]++;
                    guardsOrders.Remove(secondInput[i]);
                }
                else
                {
                    firstInput[1]--;
                    guardsOrders.Add(secondInput[i]);
                }
                if (firstInput[1] < 0)
                {
                    enougthGuards = false;
                    break;
                }
            }

            // Getting Results
            if (enougthGuards)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
