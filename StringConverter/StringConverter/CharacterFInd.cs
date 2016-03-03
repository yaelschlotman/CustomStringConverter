using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    public static class CharacterFInd
    {
        public static void FindElementsInString(char characterToFind)
        {
            Console.WriteLine("Find element in a string:  " + Environment.NewLine);
            string stringToEvaluate = UserInput.GetUserInputAsString("Enter string to evaluate: ");
            char[] newCharArray = stringToEvaluate.ToCharArray();
            int numberOfMatchesInString = 0;
            foreach (char letterInArray in newCharArray)
            {
                if (letterInArray == characterToFind)
                {
                    numberOfMatchesInString++;
                }
            }
            if (numberOfMatchesInString >= 1)
            {
                Console.WriteLine("Yes, there are " + numberOfMatchesInString + " 's.");
            }
            else
            {
                Console.WriteLine("No matches, or cannot evaluate.");
            }
            Console.Write(Environment.NewLine);
        }
    }
}
