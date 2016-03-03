using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            StringToUpper.ConvertStringToUpperCase();
            StringToLower.ConvertStringToLower();
            CharacterReplace.ReplaceElementInString("Mississippi", 'i', 'x'); 
            StringLength.GetStringLengthCount();
            StringSplit.SplitStringIntoCharacters();          
            CharacterFInd.FindElementsInString('s');

            Console.ReadKey();
        }
    }
}
