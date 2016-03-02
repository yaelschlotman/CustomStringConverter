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
            StringConverter stringConverter = new StringConverter();
            StringList stringList = new StringList();
            ToUpper toUpper = new ToUpper();
            //stringConverter.SplitStringIntoCharacters("Hey There");
            //stringConverter.GetStringLengthCount("Hey There.");
            //stringConverter.CreateCharArrayFromString("Hey There.");
            stringConverter.ConvertStringToUpperCase("Hey There.");
            stringConverter.ConvertStringToLowerCase("HEY THERE.");
            Console.ReadKey();
        }
    }
}
