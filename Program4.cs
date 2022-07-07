using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            char rightBracket = '(';
            char leftBracket = ')';          
            int rightBracketCount = 0;
            int leftBracketCount = 0;
            bool areRightBracketFirst;
            int bracketEqual;
            int maxDepth=0;
            bool isCorrect = true;
          
            Console.WriteLine("Ведитие строку из символов '{0}' и '{1}'", rightBracket, leftBracket)  ;
            userInput = Console.ReadLine();

            foreach (var text1 in userInput)
            {
                if (text1 == rightBracket)
                {
                    rightBracketCount++;

                }
                else if (text1 == leftBracket)
                {
                    leftBracketCount++;
                }

                bracketEqual = rightBracketCount - leftBracketCount;
                if (bracketEqual == 0)
                {
                    isCorrect = true;
                }
                else if (bracketEqual < 0)
                {
                    isCorrect = false;
                    break;
                }
                else if (bracketEqual > 0 && bracketEqual > maxDepth)
                {
                    isCorrect = false;
                    maxDepth++;                    
                }
                else
                {
                    isCorrect = false;
                }

            }                        
      
            if (isCorrect)
            {
               Console.WriteLine ("Скобочное выражение корректное и максимум глубины скобок" +
                   " равняется " + maxDepth); 
            }
            else
            {
                Console.WriteLine("Скобочное выражение НЕкорректное");
            }
        }
    }
}
