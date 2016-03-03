using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    public static class StringSplit
    {
        public static void SplitStringIntoCharacters()
        {
            Console.WriteLine("Split string: " + Environment.NewLine);
            string stringToSplit = UserInput.GetUserInputAsString("Enter string to convert to split:");
            foreach (char letterInString in stringToSplit) 
            {
                Console.Write(letterInString.ToString() + ", ");
            }
            Console.Write(Environment.NewLine);
        }
    }
}
