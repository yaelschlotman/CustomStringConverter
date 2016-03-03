using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace StringConverter
{
    public class StringConverter
    {
        public char[] CreateCharArrayFromString(string stringToConvert)
        {
            char[] newCharArray = stringToConvert.ToCharArray();

            for (int i = 0; i < newCharArray.Length; i++)
            {
                char letterInArray = newCharArray[i];
                Console.Write(letterInArray);
            }

            return newCharArray;
        }
    }
}
