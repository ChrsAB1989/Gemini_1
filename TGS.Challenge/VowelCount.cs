using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */


    public class VowelCount
    {
        //Returns count of vowels in string
        public int? Count(string value)
        {
            int count = 0;

            //If value is null throw exception
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException();
            }
            else
            {
                //Loop through char's in string to check for vowels
                for (int i = 0; i < value.Length; i++)
                {
                    //Check for vowel
                    if (IsVowel(value[i]))
                    {
                        ++count;
                    }
                }

                return count;
            }
        }

        //Function to check if char is a vowel
        //Returns true is char is a vowel
        public static bool IsVowel(char ch)
        {
            ch = char.ToLower(ch);
            return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');
        }
    }
}
