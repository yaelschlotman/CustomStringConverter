using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringConverter
{
    public static class UserInput
    {
        public static string GetUserInputAsString(string userDataNeeded)
        {
            
            Console.WriteLine(  userDataNeeded);
            string userData = Console.ReadLine();
            if (userData == null) throw new ArgumentNullException(nameof(userData));
            Console.WriteLine("String to convert: " + userData);  
            return userData;
        }
    }
}
