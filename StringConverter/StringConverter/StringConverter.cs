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
        bool DoesContain;
        
        public char[] CreateCharArrayFromString(string StringToConvert)
        {
            char[] NewCharArray = StringToConvert.ToCharArray();

            for (int i = 0; i < NewCharArray.Length; i++)
            {
                char LetterInArray = NewCharArray[i];
                Console.Write(LetterInArray + ", ");
            }
            
            return NewCharArray;

        }
        public void ConvertStringToUpperCase(string StringToConvert)
        {
            char[] NewCharArray = StringToConvert.ToCharArray();
            for (int i = 0; i < NewCharArray.Length; i++)
            {
                char LetterInArray = char.ToUpper(NewCharArray[i]);
                Console.Write(LetterInArray + ", ");
            }            
        }

        public void ConvertStringToLowerCase(string StringToConvert)
        {
            char[] NewCharArray = StringToConvert.ToCharArray();
            for (int i = 0; i < NewCharArray.Length; i++)
            {
                char LetterInArray = char.ToLower(NewCharArray[i]); 
                Console.Write(LetterInArray + ", ");
            }
        }

        public void SplitStringIntoCharacters(string StringToConvert)
        {
            foreach (char x in StringToConvert)
            {
                Console.Write(x.ToString() + ", ");
            }
        }

        public void FindElementsInString(string StringToConvert, char CharacterToFind)
        {
            string NewCharString = CharacterToFind.ToString();
            string y;
            List<string> CharacterList = new List<string>();
            foreach (char x in StringToConvert)
            {
                y = x.ToString();
                CharacterList.Add(y);
            }
            foreach (string StringInList in CharacterList)
            {
                if (NewCharString == StringInList)
                {
                    DoesContain = true;
                }
            }
        }

        public void ReplaceElementsInString(string StringToConvert)
        {

        }


        public void GetStringLengthCount(string StringToConvert)
        {
            int StringCharacterCount;
            string y;
            List<string> CharacterList = new List<string>();
            foreach (char x in StringToConvert)
            {
                y = x.ToString();
                CharacterList.Add(y);
            }

            StringCharacterCount = CharacterList.Count();
            Console.WriteLine("String length count: " + StringCharacterCount);
        }
    }
}
