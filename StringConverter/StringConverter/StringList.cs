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

        public void CreateListFromString(string stringToConvert)
        {
            string y;
            List<string> characterList = new List<string>();
            foreach (char x in stringToConvert)
            {
                y = x.ToString();
                characterList.Add(y);
            }

            foreach (string c in characterList)
            {
                Console.Write(c + ", ");
            }
            
        }

        public List<string> CreateListFromFirstWordInString(string stringToConvert)
        {
            string y;
            List<string> listFromFirstWord = new List<string>();

            foreach (char x in stringToConvert)
            {
                y = x.ToString();
               
            }
            foreach (string s in listFromFirstWord)
            {
                Console.Write(s);
            }      
                return listFromFirstWord;
        }
    }
}
