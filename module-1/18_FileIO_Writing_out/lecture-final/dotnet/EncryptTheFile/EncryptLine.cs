using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptTheFile
{
    
    public class EncryptLine
    {
        public static string Encrypt(string data,int shiftNumber)
        {
            string returnEncrypted = "";

            foreach(char c in data)
            {
                char cShifted =  (char) (c + shiftNumber);
                returnEncrypted += cShifted; 
            }

            return returnEncrypted; 
        }



    }
}
