using System;

namespace StringMethods
{
    public class StringGetMethods
    {
        public static String GetSubstring(String mainString, int startPosition,int numOfCharacters)
        {
            String subString = "";
            for(int i = startPosition - 1; i <= numOfCharacters; i++)
            {
                subString = subString+mainString[i];
            }
            return subString;

        }
    }
}
