using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    public static class StringToUpper
    {
        public static char[] ConvertStringToUpperCase()
        {
            Console.WriteLine("Convert string to upper case:  " + Environment.NewLine);
            string stringToConvert = UserInput.GetUserInputAsString("Enter string to convert to upper case");

            char[] stringToUpper = stringToConvert.ToCharArray();

            for (int i = 0; i < stringToUpper.Length; i++)
            {
                char letterInArray = stringToUpper[i];
                Console.Write(letterInArray);
            }
            for (int i = 0; i < stringToUpper.Length; i++)
            {

                if (stringToUpper[i] == 'a')
                {
                    stringToUpper[i] = 'A';
                }
                else if (stringToUpper[i] == 'b')
                {
                    stringToUpper[i] = 'B';
                }
                else if (stringToUpper[i] == 'c')
                {
                    stringToUpper[i] = 'C';
                }
                else if (stringToUpper[i] == 'd')
                {
                    stringToUpper[i] = 'D';
                }
                else if (stringToUpper[i] == 'e')
                {
                    stringToUpper[i] = 'E';
                }
                else if (stringToUpper[i] == 'f')
                {
                    stringToUpper[i] = 'F';
                }
                else if (stringToUpper[i] == 'g')
                {
                    stringToUpper[i] = 'G';
                }
                else if (stringToUpper[i] == 'h')
                {
                    stringToUpper[i] = 'H';
                }
                else if (stringToUpper[i] == 'i')
                {
                    stringToUpper[i] = 'I';
                }
                else if (stringToUpper[i] == 'j')
                {
                    stringToUpper[i] = 'J';
                }
                else if (stringToUpper[i] == 'k')
                {
                    stringToUpper[i] = 'K';
                }
                else if (stringToUpper[i] == 'l')
                {
                    stringToUpper[i] = 'L';
                }
                else if (stringToUpper[i] == 'm')
                {
                    stringToUpper[i] = 'M';
                }
                else if (stringToUpper[i] == 'n')
                {
                    stringToUpper[i] = 'N';
                }
                else if (stringToUpper[i] == 'o')
                {
                    stringToUpper[i] = 'O';
                }
                else if (stringToUpper[i] == 'p')
                {
                    stringToUpper[i] = 'P';
                }
                else if (stringToUpper[i] == 'q')
                {
                    stringToUpper[i] = 'Q';
                }
                else if (stringToUpper[i] == 'r')
                {
                    stringToUpper[i] = 'R';
                }
                else if (stringToUpper[i] == 's')
                {
                    stringToUpper[i] = 'S';
                }
                else if (stringToUpper[i] == 't')
                {
                    stringToUpper[i] = 'T';
                }
                else if (stringToUpper[i] == 'u')
                {
                    stringToUpper[i] = 'U';
                }
                else if (stringToUpper[i] == 'v')
                {
                    stringToUpper[i] = 'V';
                }
                else if (stringToUpper[i] == 'w')
                {
                    stringToUpper[i] = 'W';
                }
                else if (stringToUpper[i] == 'x')
                {
                    stringToUpper[i] = 'X';
                }
                else if (stringToUpper[i] == 'y')
                {
                    stringToUpper[i] = 'Y';
                }
                else if (stringToUpper[i] == 'z')
                {
                    stringToUpper[i] = 'Z';
                }

                char c = stringToUpper[i];
            }

            Console.WriteLine(Environment.NewLine + "This string to upper case:" + Environment.NewLine);
            for (int i = 0; i < stringToUpper.Length; i++)
            {
                char letterInArray = stringToUpper[i];

                Console.Write(letterInArray);
            }
            Console.Write(Environment.NewLine);
            return stringToUpper;
        }

        
    }
}
