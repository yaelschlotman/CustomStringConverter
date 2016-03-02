using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringConverter
{
    public class StringList
    {
        
        public string[] UpperCaseAlphabet =
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
            "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        public string[] LowerCaseAlphabet =
        {
            "a", "b", "c", "d" ,"e", "f", "g", "h", "i", "j", "k","l", "m",
            "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        public void CreateListFromString(string StringToConvert)
        {
            string y;
            List<string> CharacterList = new List<string>();
            foreach (char x in StringToConvert)
            {
                y = x.ToString();
                CharacterList.Add(y);
            }

            foreach (string c in CharacterList)
            {
                Console.Write(c + ", ");
            }
            
        }

        public List<string> CreateListFromFirstWordInString(string StringToConvert)
        {
            string y;
            List<string> ListFromFirstWord = new List<string>();

            foreach (char x in StringToConvert)
            {
                y = x.ToString();
               
            }
            foreach (string s in ListFromFirstWord)
            {
                Console.Write(s);
            }      
                return ListFromFirstWord;
        }
    }
}
