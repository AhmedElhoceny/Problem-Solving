using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.NewPassword
{
    public class NewPassword_Solve
    {
        public void NewPassword_solve() {
            char[] alphas = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
            var Keys = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
            var workingChars = alphas.Take(Keys[1]).ToArray();
            string result = "";
            for (int i = 0; i < Keys[0]; i++)
            {
                if (i > (workingChars.Length - 1))
                    i = 0;
                result += workingChars[i];
                if (result.Length >= Keys[0])
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
