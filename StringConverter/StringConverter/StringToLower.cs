using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    public static class StringToLower
    {
        public static char[] ConvertStringToLower()
        {
            Console.WriteLine("Convert string to lower case:  " + Environment.NewLine);
            string stringToConvert = UserInput.GetUserInputAsString("Enter string to convert to lower case");
            char[] stringToLower = stringToConvert.ToCharArray();

            for (int i = 0; i < stringToLower.Length; i++)
            {
                char letterInArray = stringToLower[i];
                Console.Write(letterInArray);
            }
            for (int i = 0; i < stringToLower.Length; i++)
            {

                if (stringToLower[i] == 'A')
                {
                    stringToLower[i] = 'a';
                }
                else if (stringToLower[i] == 'B')
                {
                    stringToLower[i] = 'b';
                }
                else if (stringToLower[i] == 'C')
                {
                    stringToLower[i] = 'c';
                }
                else if (stringToLower[i] == 'D')
                {
                    stringToLower[i] = 'd';
                }
                else if (stringToLower[i] == 'E')
                {
                    stringToLower[i] = 'e';
                }
                else if (stringToLower[i] == 'F')
                {
                    stringToLower[i] = 'f';
                }
                else if (stringToLower[i] == 'G')
                {
                    stringToLower[i] = 'g';
                }
                else if (stringToLower[i] == 'H')
                {
                    stringToLower[i] = 'h';
                }
                else if (stringToLower[i] == 'I')
                {
                    stringToLower[i] = 'i';
                }
                else if (stringToLower[i] == 'J')
                {
                    stringToLower[i] = 'j';
                }
                else if (stringToLower[i] == 'K')
                {
                    stringToLower[i] = 'l';
                }
                else if (stringToLower[i] == 'L')
                {
                    stringToLower[i] = 'l';
                }
                else if (stringToLower[i] == 'M')
                {
                    stringToLower[i] = 'm';
                }
                else if (stringToLower[i] == 'N')
                {
                    stringToLower[i] = 'n';
                }
                else if (stringToLower[i] == 'O')
                {
                    stringToLower[i] = 'o';
                }
                else if (stringToLower[i] == 'P')
                {
                    stringToLower[i] = 'p';
                }
                else if (stringToLower[i] == 'Q')
                {
                    stringToLower[i] = 'q';
                }
                else if (stringToLower[i] == 'R')
                {
                    stringToLower[i] = 'r';
                }
                else if (stringToLower[i] == 'S')
                {
                    stringToLower[i] = 's';
                }
                else if (stringToLower[i] == 'T')
                {
                    stringToLower[i] = 't';
                }
                else if (stringToLower[i] == 'U')
                {
                    stringToLower[i] = 'u';
                }
                else if (stringToLower[i] == 'V')
                {
                    stringToLower[i] = 'v';
                }
                else if (stringToLower[i] == 'W')
                {
                    stringToLower[i] = 'w';
                }
                else if (stringToLower[i] == 'X')
                {
                    stringToLower[i] = 'x';
                }
                else if (stringToLower[i] == 'Y')
                {
                    stringToLower[i] = 'y';
                }
                else if (stringToLower[i] == 'Z')
                {
                    stringToLower[i] = 'z';
                }

                char c = stringToLower[i];
            }

            Console.WriteLine(Environment.NewLine + "This string to lower case:" + Environment.NewLine);
            for (int i = 0; i < stringToLower.Length; i++)
            {
                char letterInArray = stringToLower[i];

                Console.Write(letterInArray);
            }
            Console.Write(Environment.NewLine);
            return stringToLower;
        }
    }
}
