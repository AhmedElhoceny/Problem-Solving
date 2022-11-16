using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Problems.Keyboard
{
    public class Keyboard_Solve
    {
        public void Solve()
        {
            var keyBoard = new string[] { "qwertyuiop", "asdfghjkl;", "zxcvbnm,./" };

            var shiftingSign = Console.ReadLine()[0];
            var shiftedWord = Console.ReadLine();

            var rightWord = "";

            foreach (var item in shiftedWord)
            {
                foreach (var keyBoardItem in keyBoard)
                {
                    if (shiftingSign == 'R')
                    {
                        var charIndex = keyBoardItem.IndexOf(item.ToString());
                        if (charIndex != -1)
                        {
                            if (charIndex != 0)
                                rightWord += keyBoardItem[charIndex - 1];
                        }
                    }
                    else
                    {
                        var charIndex = keyBoardItem.IndexOf(item.ToString());
                        if (charIndex != -1)
                        {
                            if (charIndex != (keyBoardItem.Length - 1))
                                rightWord += keyBoardItem[charIndex + 1];
                        }
                    }
                }
            }
            Console.WriteLine(rightWord);
        }
    }
}
