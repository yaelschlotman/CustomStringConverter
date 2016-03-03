using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    public static class StringLength
    {
        public static void GetStringLengthCount()
        {
            Console.WriteLine("Get string length:  " + Environment.NewLine);        
            string stringToEvaluate = UserInput.GetUserInputAsString("Enter string to evaluate.");
            char[] CharArrayToCount = stringToEvaluate.ToCharArray();
            int stringCharacterCount = CharArrayToCount.Count();
            
            Console.WriteLine("String length count: " + stringCharacterCount);
        }
    }
}
