using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DorisShisaWebApplication
{
    public class AutoGeneratePassword
    {/*! 
   auto generate employee password when an employee is added to the database
       */
        static char[] acceptedCharecters = { '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        static Random rand = new Random();
        static int passwordLength = 6;
        public static char[] password = new char[passwordLength];

        public static string generatePassword()
        {
            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = acceptedCharecters[rand.Next(0, acceptedCharecters.Length)];
            }
            return new string(password);

        }

    }
}