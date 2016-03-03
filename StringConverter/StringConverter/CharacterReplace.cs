using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    public static class CharacterReplace
    {
        public static char[] ReplaceElementInString(string stringToModify, char elementToFind, char elementToSubstitute)
        {
            Console.WriteLine("Replace element in a string:  " + Environment.NewLine);
            char[] charArrayToModify  = stringToModify.ToCharArray();
            Console.WriteLine("String to modify:  ");
            for (int i = 0; i< charArrayToModify.Length; i++)
            {
                char letterInArray = charArrayToModify[i];
                Console.Write(letterInArray);                
            }

            for (int i = 0; i< charArrayToModify.Length; i++)
            {
                if (charArrayToModify[i] == elementToFind)
                {
                    charArrayToModify[i] = elementToSubstitute;
                }
            }

            Console.WriteLine(Environment.NewLine + "Modified String:  ");
            for (int i = 0; i < charArrayToModify.Length; i++)
            {
                char letterInArray = charArrayToModify[i];
                Console.Write(letterInArray);
                
            }
            Console.Write(Environment.NewLine);
            return charArrayToModify;
        }
    }
}
