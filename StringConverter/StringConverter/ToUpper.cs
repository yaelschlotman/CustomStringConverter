using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    public class ToUpper
    {
        StringList stringList = new StringList();
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

        string a = "a";
        string b = "b";
        string c = "c";
        string A = "A";
        string B = "B";
        string C = "C";
        

        public void ConvertStringToUpper(string StringToConvert)
        {
            string y;
            List<string> CharacterList = new List<string>();
            
            foreach (char x in StringToConvert)
            {
                y = x.ToString();
                CharacterList.Add(y);
            }

            string[] CharacterArray = new string[CharacterList.Count];
            for (int i = 0; i < CharacterList.Count; i++)
            {
                foreach (string StringInList in CharacterList)
                {
                    if (StringInList == a)
                    {
                        CharacterList.Remove(a);
                        a = A;

                    }
                    else if (StringInList == b)
                    {
                        b = B;
                    }
                    else if (StringInList == c)
                    {
                        c = C;
                    }

                }
            }

            foreach (string StringInList in CharacterList)
            {
                Console.Write(StringInList + ", ");
            }


        }

    }
}
